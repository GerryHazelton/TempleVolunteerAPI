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
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<PropertyRequest>> _collResponse;
        private ServiceResponse<PropertyResponse> _response;

        public PropertyController(IPropertyService PropertyService, IMapper mapper)
        {
            _propertyService = PropertyService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<PropertyRequest>>();
            _response = new ServiceResponse<PropertyResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<PropertyRequest>>> GetAllAsync([FromBody] MiscRequest request)
        {
            _collResponse.Data = _mapper.Map<IList<PropertyRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<PropertyResponse>> GetByIdAsync(MiscRequest request)
        {
            _response.Data = _mapper.Map<PropertyResponse>(await _propertyService.GetAsync(request.GetById, request.PropertyId, request.UserId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<PropertyRequest>>> PostAsync([FromBody] PropertyRequest request)
        {
            await _propertyService.AddAsync(_mapper.Map<Property>(request), request.PropertyId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<PropertyRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<PropertyRequest>>> PutAsync([FromBody] PropertyRequest request)
        {
            await _propertyService.UpdateAsync(_mapper.Map<Property>(request), request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<PropertyRequest>>(await ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<PropertyRequest>>> DeleteAsync(MiscRequest request)
        {
            await _propertyService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<PropertyRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<Property>> ReturnCollection(int propertyId, string userId)
        {
            return await _propertyService.GetAllAsync(propertyId, userId);
        }
    }
}
