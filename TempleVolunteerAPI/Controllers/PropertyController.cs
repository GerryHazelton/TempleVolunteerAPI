using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Service;
using static TempleVolunteerAPI.Common.EnumHelper;
using Property = TempleVolunteerAPI.Domain.Property;

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
        private bool _result;

        public PropertyController(IPropertyService PropertyService, IMapper mapper)
        {
            _propertyService = PropertyService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<PropertyRequest>>();
            _response = new ServiceResponse<PropertyResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<PropertyRequest>>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<PropertyRequest>>(await ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<PropertyResponse>> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<PropertyResponse>(_propertyService.FindByCondition(x => x.PropertyId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.None));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<PropertyRequest>>> PostAsync([FromBody] PropertyRequest request)
        {
            Property property = _mapper.Map<Property>(request);

            property = _propertyService.Create(property, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<PropertyRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = property != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<PropertyRequest>>> PutAsync([FromBody] PropertyRequest request)
        {
            Property property = (Property)_propertyService.FindByCondition(x => x.PropertyId == request.PropertyId, request.PropertyId, request.UpdatedBy, WithDetails.None);

            _result = _propertyService.Update(_mapper.Map<Property>(request), request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<PropertyRequest>>(await ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<PropertyRequest>>> DeleteAsync(MiscRequest request)
        {
            Property property = (Property)_propertyService.FindByCondition(x => x.PropertyId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.None);

            _result = _propertyService.Delete(property, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<PropertyRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<Property>> ReturnCollection(int propertyId, string userId)
        {
            return (IList<Property>)_propertyService.FindAll(propertyId, userId);
        }
    }
}
