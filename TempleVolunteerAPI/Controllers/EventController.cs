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
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventRequest>> _collResponse;
        private ServiceResponse<EventResponse> _response;

        public EventController(IEventService EventService, IMapper mapper)
        {
            _eventService = EventService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventRequest>>();
            _response = new ServiceResponse<EventResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<EventRequest>>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(await ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<EventResponse>> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<EventResponse>(await _eventService.GetAsync(id, propertyId, userId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<EventRequest>>> PostAsync([FromBody] EventRequest request)
        {
            await _eventService.AddAsync(_mapper.Map<Event>(request), request.PropertyId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<EventRequest>>> PutAsync([FromBody] EventRequest request)
        {
            await _eventService.UpdateAsync(_mapper.Map<Event>(request), request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(await ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<EventRequest>>> DeleteAsync(MiscRequest request)
        {
            await _eventService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<EventRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<Event>> ReturnCollection(int propertyId, string userId)
        {
            return await _eventService.GetAllAsync(propertyId, userId);
        }
    }
}
