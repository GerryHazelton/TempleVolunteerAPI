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
    public class AreaController : ControllerBase
    {
        private readonly IAreaService _AreaService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<AreaResponse>> _collResponse;
        private ServiceResponse<AreaResponse> _response;

        public AreaController(IAreaService AreaService, IMapper mapper)
        {
            _AreaService = AreaService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<AreaResponse>>();
            _response = new ServiceResponse<AreaResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<AreaResponse>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<AreaResponse>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<AreaResponse>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<AreaResponse>(await _AreaService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<AreaResponse>>> PostAsync([FromBody] AreaResponse request)
        {
            if (await _AreaService.AddAsync(_mapper.Map<Area>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<AreaResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create Area");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<AreaResponse>>> PutAsync([FromBody] AreaResponse request)
        {
            if (await _AreaService.UpdateAsync(_mapper.Map<Area>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<AreaResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update Area");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<AreaResponse>>> DeleteAsync(int id)
        {
            if (await _AreaService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<AreaResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete Area");
            }
        }

        private async Task<IList<Area>> ReturnCollection()
        {
            return await _AreaService.GetAllAsync();
        }
    }
}
