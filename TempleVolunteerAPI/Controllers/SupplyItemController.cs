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
    public class SupplyItemController : ControllerBase
    {
        private readonly ISupplyItemService _supplyItemService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<SupplyItemRequest>> _collResponse;
        private ServiceResponse<SupplyItemResponse> _response;

        public SupplyItemController(ISupplyItemService SupplyItemService, IMapper mapper)
        {
            _supplyItemService = SupplyItemService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<SupplyItemRequest>>();
            _response = new ServiceResponse<SupplyItemResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<SupplyItemRequest>>> GetAllAsync(int propertyId, string userId)
        {
            try
            {
                _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(await ReturnCollection(propertyId, userId));
                _collResponse.Success = _collResponse.Data != null ? true : false;
            }
            catch(Exception ex)
            {

            }

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<SupplyItemResponse>> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<SupplyItemResponse>(await _supplyItemService.GetAsync(id, propertyId, userId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<SupplyItemRequest>>> PostAsync([FromBody] SupplyItemRequest request)
        {
            await _supplyItemService.AddAsync(_mapper.Map<SupplyItem>(request), request.SupplyItemId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(await ReturnCollection(request.SupplyItemId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<SupplyItemRequest>>> PutAsync([FromBody] SupplyItemRequest request)
        {
            await _supplyItemService.UpdateAsync(_mapper.Map<SupplyItem>(request), request.SupplyItemId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(await ReturnCollection(request.SupplyItemId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<SupplyItemRequest>>> DeleteAsync(MiscRequest request)
        {
            await _supplyItemService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<SupplyItem>> ReturnCollection(int SupplyItemId, string userId)
        {
            return await _supplyItemService.GetAllAsync(SupplyItemId, userId);
        }
    }
}
