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
    public class EventTaskController : ControllerBase
    {
        private readonly IEventTaskService _eventTaskService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventTaskRequest>> _collResponse;
        private ServiceResponse<EventTaskRequest> _response;
        private bool _result;

        public EventTaskController(IEventTaskService EventTaskService, IMapper mapper)
        {
            _eventTaskService = EventTaskService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventTaskRequest>>();
            _response = new ServiceResponse<EventTaskRequest>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<EventTaskRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<EventTaskRequest> GetByIdAsync(int id, int propertyId, string userId)
        {
            var eventTask = _eventTaskService.FindByCondition(x => x.EventTaskId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).FirstOrDefault();
            _response.Data = _mapper.Map<EventTaskRequest>(eventTask);
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<EventTaskRequest>> PostAsync([FromBody] EventTaskRequest request)
        {
            EventTask eventTask = _mapper.Map<EventTask>(request);
            eventTask = (EventTask)_eventTaskService.Create(eventTask, request.PropertyId, request.CreatedBy);
            _result = _eventTaskService.Update(eventTask, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<EventTaskRequest>> PutAsync([FromBody] EventTaskRequest request)
        {
            EventTask eventTask = _eventTaskService.FindByCondition(x => x.EventTaskId == request.EventTaskId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            eventTask = _mapper.Map<EventTask>(request);

            _result = _eventTaskService.Update(eventTask, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<EventTaskRequest>> DeleteAsync(int eventTaskId, int propertyId, string userId)
        {
            EventTask eventTask = _eventTaskService.FindByCondition(x => x.EventTaskId == eventTaskId, propertyId, userId, WithDetails.Yes).FirstOrDefault();

            _result = _eventTaskService.Delete(eventTask, propertyId, userId);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<EventTask> ReturnCollection(int propertyId, string userId)
        {
            return _eventTaskService.FindAll(propertyId, userId).ToList();
        }
    }
}
