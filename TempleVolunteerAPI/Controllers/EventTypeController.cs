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
    public class EventTypeController : ControllerBase
    {
        private readonly IEventTypeService _EventTypeService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventTypeResponse>> _collResponse;
        private ServiceResponse<EventTypeResponse> _response;

        public EventTypeController(IEventTypeService EventTypeService, IMapper mapper)
        {
            _EventTypeService = EventTypeService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventTypeResponse>>();
            _response = new ServiceResponse<EventTypeResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<EventTypeResponse>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<EventTypeResponse>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<EventTypeResponse>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<EventTypeResponse>(await _EventTypeService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<EventTypeResponse>>> PostAsync([FromBody] EventTypeResponse request)
        {
            if (await _EventTypeService.AddAsync(_mapper.Map<EventType>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<EventTypeResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create EventType");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<EventTypeResponse>>> PutAsync([FromBody] EventTypeResponse request)
        {
            if (await _EventTypeService.UpdateAsync(_mapper.Map<EventType>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<EventTypeResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update EventType");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<EventTypeResponse>>> DeleteAsync(int id)
        {
            if (await _EventTypeService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<EventTypeResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete EventType");
            }
        }

        private async Task<IList<EventType>> ReturnCollection()
        {
            return await _EventTypeService.GetAllAsync();
        }
    }
}
