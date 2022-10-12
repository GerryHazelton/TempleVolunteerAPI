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
    public class EventTypeController : ControllerBase
    {
        private readonly IEventTypeService _eventTypeService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventTypeRequest>> _collResponse;
        private ServiceResponse<EventTypeResponse> _response;

        public EventTypeController(IEventTypeService EventTypeService, IMapper mapper)
        {
            _eventTypeService = EventTypeService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventTypeRequest>>();
            _response = new ServiceResponse<EventTypeResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<EventTypeRequest>>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<EventTypeRequest>>(await ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<EventTypeResponse>> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<EventTypeResponse>(await _eventTypeService.GetByIdAsync(id, propertyId, userId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<EventTypeRequest>>> PostAsync([FromBody] EventTypeRequest request)
        {
            await _eventTypeService.AddAsync(_mapper.Map<EventType>(request), request.PropertyId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTypeRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<EventTypeRequest>>> PutAsync([FromBody] EventTypeRequest request)
        {
            await _eventTypeService.UpdateAsync(_mapper.Map<EventType>(request), request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventTypeRequest>>(await ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<EventTypeRequest>>> DeleteAsync(MiscRequest request)
        {
            await _eventTypeService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<EventTypeRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<EventType>> ReturnCollection(int propertyId, string userId)
        {
            return await _eventTypeService.GetAllAsync(propertyId, userId);
        }
    }
}
