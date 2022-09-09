using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
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
        private ServiceResponse<IList<EventResponse>> _collResponse;
        private ServiceResponse<EventResponse> _response;

        public EventController(IEventService EventService, IMapper mapper)
        {
            _eventService = EventService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventResponse>>();
            _response = new ServiceResponse<EventResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<EventResponse>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<EventResponse>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<EventResponse>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<EventResponse>(await _eventService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<EventResponse>>> PostAsync([FromBody] EventResponse request)
        {
            if (await _eventService.AddAsync(_mapper.Map<Event>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<EventResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create Event");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<EventResponse>>> PutAsync([FromBody] EventResponse request)
        {
            if (await _eventService.UpdateAsync(_mapper.Map<Event>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<EventResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update Event");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<EventResponse>>> DeleteAsync(int id)
        {
            if (await _eventService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<EventResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete Event");
            }
        }

        private async Task<IList<Event>> ReturnCollection()
        {
            return await _eventService.GetAllAsync();
        }
    }
}
