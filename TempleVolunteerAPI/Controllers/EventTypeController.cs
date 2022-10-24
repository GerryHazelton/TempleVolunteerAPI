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
    public class EventTypeController : ControllerBase
    {
        private readonly IEventTypeService _eventTypeService;
        private readonly IEventTypeAreaService _eventTypeAreaService;
        private readonly IAreaService _areaService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventTypeRequest>> _collResponse;
        private ServiceResponse<EventTypeResponse> _response;
        private bool _result;

        public EventTypeController(IEventTypeService EventTypeService, IMapper mapper, IEventTypeAreaService eventTypeAreaService, IAreaService areaService)
        {
            _eventTypeService = EventTypeService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventTypeRequest>>();
            _response = new ServiceResponse<EventTypeResponse>();
            _eventTypeAreaService = eventTypeAreaService;
            _areaService = areaService;
        }

        [HttpGet("GetAll")]
        public ServiceResponse<IList<EventTypeRequest>> GetAll(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<EventTypeRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetById")]
        public ServiceResponse<EventTypeResponse> GetById(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<EventTypeResponse>(_eventTypeService.FindByCondition(x => x.EventTypeId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.None));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("Post")]
        public ServiceResponse<IList<EventTypeRequest>> Post([FromBody] EventTypeRequest request)
        {
            EventType eventType = _mapper.Map<EventType>(request);
            eventType = (EventType)_eventTypeService.Create(eventType, request.PropertyId, request.CreatedBy);

            if (request.AreaIds.Length > 0)
            {
                eventType.Areas = GetAreas(eventType, request.AreaIds, request.PropertyId, request.CreatedBy);
            }

            _result = _eventTypeService.Update(eventType, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTypeRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("Put")]
        public ServiceResponse<IList<EventTypeRequest>> Put([FromBody] EventTypeRequest request)
        {
            EventType eventType = _eventTypeService.FindByCondition(x => x.EventTypeId == request.EventTypeId, request.PropertyId, request.UpdatedBy, WithDetails.EventEventType).FirstOrDefault();
            eventType = _mapper.Map<EventType>(request);
            eventType.Areas.Clear();

            var eventTypeAreas = _eventTypeAreaService.FindByCondition(x => x.EventTypeId == eventType.EventTypeId, request.PropertyId, request.UpdatedBy, WithDetails.None).ToList();

            foreach (EventTypeArea eta in eventTypeAreas)
            {
                _eventTypeAreaService.Delete(eta, request.PropertyId, request.UpdatedBy);
            }

            if (request.AreaIds.Length > 0)
            {
                eventType.Areas = GetAreas(eventType, request.AreaIds, request.PropertyId, request.UpdatedBy);
            }

            _result = _eventTypeService.Update(eventType, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTypeRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("Delete")]
        public ServiceResponse<IList<EventTypeRequest>> Delete(MiscRequest request)
        {
            EventType eventType = _eventTypeService.FindByCondition(x => x.EventTypeId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.EventEventType).FirstOrDefault();

            _result = _eventTypeService.Delete(eventType, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<EventTypeRequest>>(ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<EventTypeArea> GetAreas(EventType eventType, int[] areaIds, int propertyId, string userId)
        {
            Area area;
            EventTypeArea addEventTypeArea;
            IList<EventTypeArea> eventTypeAreas = new List<EventTypeArea>();

            foreach (int areaId in areaIds)
            {
                area = _areaService.FindByCondition(x => x.AreaId == areaId, propertyId, userId, WithDetails.None).FirstOrDefault();
                addEventTypeArea = new EventTypeArea { EventType = eventType, Area = area };
                eventTypeAreas.Add(addEventTypeArea);
            }

            return eventTypeAreas;
        }

        private IList<EventType> ReturnCollection(int propertyId, string userId)
        {
            return _eventTypeService.FindAll(propertyId, userId).ToList();
        }
    }
}
