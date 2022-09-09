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
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<PropertyResponse>> _collResponse;
        private ServiceResponse<PropertyResponse> _response;

        public PropertyController(IPropertyService propertyService, IMapper mapper)
        {
            _propertyService = propertyService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<PropertyResponse>>();
            _response = new ServiceResponse<PropertyResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<PropertyResponse>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<PropertyResponse>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<PropertyResponse>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<PropertyResponse>(await _propertyService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<PropertyResponse>>> PostAsync([FromBody] PropertyRequest request)
        {
            if (await _propertyService.AddAsync(_mapper.Map<Property>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<PropertyResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create Property");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<PropertyResponse>>> PutAsync([FromBody] PropertyResponse request)
        {
            if (await _propertyService.UpdateAsync(_mapper.Map<Property>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<PropertyResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update Property");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<PropertyResponse>>> DeleteAsync(int id, string userId)
        {
            if (await _propertyService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<PropertyResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete Property");
            }
        }

        private async Task<IList<Property>> ReturnCollection()
        {
            return await _propertyService.GetAllAsync();
        }
    }
}
