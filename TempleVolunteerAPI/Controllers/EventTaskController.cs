using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Service;

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

        public EventTaskController(IEventTaskService EventTaskService, IMapper mapper)
        {
            _eventTaskService = EventTaskService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventTaskRequest>>();
            _response = new ServiceResponse<EventTaskResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<EventTaskRequest>>> GetAllAsync([FromBody] MiscRequest request)
        {
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<EventTaskResponse>> GetByIdAsync(MiscRequest request)
        {
            _response.Data = _mapper.Map<EventTaskResponse>(await _eventTaskService.GetAsync(request.GetById, request.PropertyId, request.UserId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<EventTaskRequest>>> PostAsync([FromBody] EventTaskRequest request)
        {
            await _eventTaskService.AddAsync(_mapper.Map<EventTask>(request), request.PropertyId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<EventTaskRequest>>> PutAsync([FromBody] EventTaskRequest request)
        {
            await _eventTaskService.UpdateAsync(_mapper.Map<EventTask>(request), request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(await ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<EventTaskRequest>>> DeleteAsync(MiscRequest request)
        {
            await _eventTaskService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<EventTaskRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<EventTask>> ReturnCollection(int propertyId, string userId)
        {
            return await _eventTaskService.GetAllAsync(propertyId, userId);
        }
    }
}
