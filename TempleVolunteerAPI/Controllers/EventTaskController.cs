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

        public EventTaskController(IEventTaskService EventTaskService, IMapper mapper, ISupplyItemService supplyItemService)
        {
            _eventTaskService = EventTaskService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventTaskRequest>>();
            _response = new ServiceResponse<EventTaskResponse>();
        }

        [HttpGet("GetAll")]
        public ServiceResponse<IList<EventTaskRequest>> GetAll(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetById")]
        public ServiceResponse<EventTaskResponse> GetById(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<EventTaskResponse>(_eventTaskService.FindByCondition(x => x.EventTaskId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.None));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("Post")]
        public ServiceResponse<IList<EventTaskRequest>> Post([FromBody] EventTaskRequest request)
        {
            EventTask eventTask = _mapper.Map<EventTask>(request);
            eventTask = (EventTask)_eventTaskService.Create(eventTask, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = eventTask != null ? true : false;

            return _collResponse;
        }

        [HttpPut("Put")]
        public ServiceResponse<IList<EventTaskRequest>> Put([FromBody] EventTaskRequest request)
        {
            EventTask eventTask = _eventTaskService.FindByCondition(x => x.EventTaskId == request.EventTaskId, request.PropertyId, request.UpdatedBy, WithDetails.None).FirstOrDefault();
            eventTask = _mapper.Map<EventTask>(request);

            _result = _eventTaskService.Update(eventTask, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _result ? true : false;

            return _collResponse;
        }

        [HttpDelete("Delete")]
        public ServiceResponse<IList<EventTaskRequest>> Delete(MiscRequest request)
        {
            EventTask eventTask = _eventTaskService.FindByCondition(x => x.EventTaskId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.None).FirstOrDefault();

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
