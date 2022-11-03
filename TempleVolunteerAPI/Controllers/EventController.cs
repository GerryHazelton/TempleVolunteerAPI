using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Service;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.API
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _templeEventService;
        private readonly IEventEventTypeService _templeEventSupplyItemService;
        private readonly IEventTypeService _eventTypeService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventRequest>> _collResponse;
        private ServiceResponse<EventResponse> _response;
        private bool _result;

        public EventController(IEventService eventService, IMapper mapper, IEventEventTypeService templeEventSupplyItemService, IEventTypeService eventTypeService)
        {
            _templeEventService = eventService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventRequest>>();
            _response = new ServiceResponse<EventResponse>();
            _templeEventSupplyItemService = templeEventSupplyItemService;
            _eventTypeService = eventTypeService;
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<EventRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<EventResponse> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<EventResponse>(_templeEventService.FindByCondition(x => x.EventId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.No));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<EventRequest>> PostAsync([FromBody] EventRequest request)
        {
            Event templeEvent = _mapper.Map<Event>(request);
            templeEvent = (Event)_templeEventService.Create(templeEvent, request.PropertyId, request.CreatedBy);

            if (request.EventTypeIds.Length > 0)
            {
                templeEvent.EventTypes = GetEventTypes(templeEvent, request.EventTypeIds, request.PropertyId, request.CreatedBy);
            }

            _result = _templeEventService.Update(templeEvent, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<EventRequest>> PutAsync([FromBody] EventRequest request)
        {
            Event templeEvent = _templeEventService.FindByCondition(x => x.EventId == request.EventId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            templeEvent = _mapper.Map<Event>(request);
            templeEvent.EventTypes.Clear();

            var templeEventTypes = _templeEventSupplyItemService.FindByCondition(x => x.EventId == templeEvent.EventId, request.PropertyId, request.UpdatedBy, WithDetails.No).ToList();

            foreach (EventEventType tet in templeEventTypes)
            {
                _templeEventSupplyItemService.Delete(tet, request.PropertyId, request.UpdatedBy);
            }

            if (request.EventTypeIds.Length > 0)
            {
                templeEvent.EventTypes = GetEventTypes(templeEvent, request.EventTypeIds, request.PropertyId, request.UpdatedBy);
            }

            _result = _templeEventService.Update(templeEvent, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<EventRequest>> DeleteAsync(MiscRequest request)
        {
            Event templeEvent = _templeEventService.FindByCondition(x => x.EventId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.Yes).FirstOrDefault();

            _result = _templeEventService.Delete(templeEvent, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<EventEventType> GetEventTypes(Event templeEvent, int[] eventTypeIds, int propertyId, string userId)
        {
            EventType eventType;
            EventEventType addEventEventType;
            IList<EventEventType> templeEventSupplyItems = new List<EventEventType>();

            foreach (int eventTypeId in eventTypeIds)
            {
                eventType = _eventTypeService.FindByCondition(x => x.EventTypeId == eventTypeId, propertyId, userId, WithDetails.No).FirstOrDefault();
                addEventEventType = new EventEventType { Event = templeEvent, EventType = eventType };
                templeEventSupplyItems.Add(addEventEventType);
            }

            return templeEventSupplyItems;
        }

        private IList<Event> ReturnCollection(int propertyId, string userId)
        {
            return _templeEventService.FindAll(propertyId, userId).ToList();
        }
    }
}
