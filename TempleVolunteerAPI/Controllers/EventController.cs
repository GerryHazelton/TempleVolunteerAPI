using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.API
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IEventEventTypeService _eventEventTypeService;
        private readonly IEventTypeService _eventTypeService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventRequest>> _collResponse;
        private ServiceResponse<EventRequest> _response;
        private bool _result;

        public EventController(IEventService EventService, IMapper mapper, IEventEventTypeService eventEventTypeService, IEventTypeService eventTypeService)
        {
            _eventService = EventService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventRequest>>();
            _response = new ServiceResponse<EventRequest>();
            _eventEventTypeService = eventEventTypeService;
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
        public ServiceResponse<EventRequest> GetByIdAsync(int id, int propertyId, string userId)
        {
            var eventt = _eventService.FindByCondition(x => x.EventId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).FirstOrDefault();
            _response.Data = _mapper.Map<EventRequest>(eventt);

            if (eventt.EventTypes.Count > 0)
            {
                _response.Data.EventTypeIds = new int[eventt.EventTypes.Count];
                for (int i = 0; i < eventt.EventTypes.Count; i++)
                {
                    _response.Data.EventTypeIds[i] = eventt.EventTypes.ToList()[i].EventTypeId;
                }
            }

            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<EventRequest>> PostAsync([FromBody] EventRequest request)
        {
            Event eventt = _mapper.Map<Event>(request);
            eventt = (Event)_eventService.Create(eventt, request.PropertyId, request.CreatedBy);

            if (request.EventTypeIds.Length > 0)
            {
                eventt.EventTypes = GetEventTypes(eventt, request.EventTypeIds, request.PropertyId, request.CreatedBy);
            }

            _result = _eventService.Update(eventt, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<EventRequest>> PutAsync([FromBody] EventRequest request)
        {
            Event eventt = _eventService.FindByCondition(x => x.EventId == request.EventId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            eventt = _mapper.Map<Event>(request);

            if (eventt.EventTypes != null && eventt.EventTypes.Count > 0)
            {
                eventt.EventTypes.Clear();
            }

            var eventEventTypes = _eventEventTypeService.FindByCondition(x => x.EventId == eventt.EventId, request.PropertyId, request.UpdatedBy, WithDetails.No).ToList();

            foreach (EventEventType aet in eventEventTypes)
            {
                _eventEventTypeService.Delete(aet, request.PropertyId, request.UpdatedBy);
            }

            if (request.EventTypeIds.Length > 0)
            {
                eventt.EventTypes = GetEventTypes(eventt, request.EventTypeIds, request.PropertyId, request.UpdatedBy);
            }

            _result = _eventService.Update(eventt, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<EventRequest>> DeleteAsync(int areaId, int propertyId, string userId)
        {
            Event area = _eventService.FindByCondition(x => x.EventId == areaId, propertyId, userId, WithDetails.Yes).FirstOrDefault();

            _result = _eventService.Delete(area, propertyId, userId);
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<EventEventType> GetEventTypes(Event eventt, int[] eventTypeIds, int propertyId, string userId)
        {
            EventType eventType;
            EventEventType addEventEventType;
            IList<EventEventType> eventEventTypes = new List<EventEventType>();

            foreach (int eventTypeId in eventTypeIds)
            {
                eventType = _eventTypeService.FindByCondition(x => x.EventTypeId == eventTypeId, propertyId, userId, WithDetails.No).FirstOrDefault();
                addEventEventType = new EventEventType { Event = eventt, EventType = eventType };
                eventEventTypes.Add(addEventEventType);
            }

            return eventEventTypes;
        }

        private IList<Event> ReturnCollection(int propertyId, string userId)
        {
            return _eventService.FindAll(propertyId, userId).ToList();
        }
    }
}
