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
    public class EventTaskController : ControllerBase
    {
        private readonly IEventTaskService _eventTaskService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventTaskResponse>> _collResponse;
        private ServiceResponse<EventTaskResponse> _response;

        public EventTaskController(IEventTaskService eventTaskService, IMapper mapper)
        {
            _eventTaskService = eventTaskService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventTaskResponse>>();
            _response = new ServiceResponse<EventTaskResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<EventTaskResponse>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<EventTaskResponse>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<EventTaskResponse>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<EventTaskResponse>(await _eventTaskService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<EventTaskResponse>>> PostAsync([FromBody] EventTaskResponse request)
        {
            if (await _eventTaskService.AddAsync(_mapper.Map<EventTask>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<EventTaskResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create Event");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<EventTaskResponse>>> PutAsync([FromBody] EventTaskResponse request)
        {
            if (await _eventTaskService.UpdateAsync(_mapper.Map<EventTask>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<EventTaskResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update Event");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<EventTaskResponse>>> DeleteAsync(int id)
        {
            if (await _eventTaskService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<EventTaskResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete Event");
            }
        }

        private async Task<IList<EventTask>> ReturnCollection()
        {
            return await _eventTaskService.GetAllAsync();
        }
    }
}
