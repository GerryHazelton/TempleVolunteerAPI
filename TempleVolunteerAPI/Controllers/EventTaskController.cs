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
    public class EventTaskController : ControllerBase
    {
        private readonly IEventTaskService _eventTaskService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventTaskRequest>> _collResponse;
        private ServiceResponse<EventTaskResponse> _response;
        private bool _result;

        public EventTaskController(IEventTaskService eventTaskService, IMapper mapper, ISupplyItemService supplyItemService)
        {
            _eventTaskService = eventTaskService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventTaskRequest>>();
            _response = new ServiceResponse<EventTaskResponse>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<EventTaskRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<EventTaskResponse> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<EventTaskResponse>(_eventTaskService.FindByCondition(x => x.EventTaskId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.No));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<EventTaskRequest>> PostAsync([FromBody] EventTaskRequest request)
        {
            EventTask eventTask = _mapper.Map<EventTask>(request);
            eventTask = (EventTask)_eventTaskService.Create(eventTask, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = eventTask != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<EventTaskRequest>> PutAsync([FromBody] EventTaskRequest request)
        {
            EventTask eventTask = _eventTaskService.FindByCondition(x => x.EventTaskId == request.EventTaskId, request.PropertyId, request.UpdatedBy, WithDetails.No).FirstOrDefault();
            eventTask = _mapper.Map<EventTask>(request);

            _result = _eventTaskService.Update(eventTask, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _result ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<EventTaskRequest>> DeleteAsync(MiscRequest request)
        {
            EventTask eventTask = _eventTaskService.FindByCondition(x => x.EventTaskId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.No).FirstOrDefault();

            _result = _eventTaskService.Delete(eventTask, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<EventTask> ReturnCollection(int propertyId, string userId)
        {
            return _eventTaskService.FindAll(propertyId, userId).ToList();
        }
    }
}
