using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;
using static TempleVolunteerAPI.Common.EnumHelper;

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
        private ServiceResponse<SupplyItemRequest> _response;
        private bool _result;

        public SupplyItemController(ISupplyItemService SupplyItemService, IMapper mapper)
        {
            _supplyItemService = SupplyItemService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<SupplyItemRequest>>();
            _response = new ServiceResponse<SupplyItemRequest>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<SupplyItemRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<SupplyItemRequest> GetByIdAsync(int id, int propertyId, string userId)
        {
            var supplyItem = _supplyItemService.FindByCondition(x => x.SupplyItemId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).FirstOrDefault();
            _response.Data = _mapper.Map<SupplyItemRequest>(supplyItem);
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<SupplyItemRequest>> PostAsync([FromBody] SupplyItemRequest request)
        {
            SupplyItem supplyItem = _mapper.Map<SupplyItem>(request);
            supplyItem = (SupplyItem)_supplyItemService.Create(supplyItem, request.PropertyId, request.CreatedBy);
            _result = _supplyItemService.Update(supplyItem, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<SupplyItemRequest>> PutAsync([FromBody] SupplyItemRequest request)
        {
            SupplyItem supplyItem = _supplyItemService.FindByCondition(x => x.SupplyItemId == request.SupplyItemId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            supplyItem = _mapper.Map<SupplyItem>(request);

            _result = _supplyItemService.Update(supplyItem, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<SupplyItemRequest>> DeleteAsync(int supplyItemId, int propertyId, string userId)
        {
            SupplyItem supplyItem = _supplyItemService.FindByCondition(x => x.SupplyItemId == supplyItemId, propertyId, userId, WithDetails.Yes).FirstOrDefault();

            _result = _supplyItemService.Delete(supplyItem, propertyId, userId);
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<SupplyItem> ReturnCollection(int propertyId, string userId)
        {
            return _supplyItemService.FindAll(propertyId, userId).ToList();
        }
    }
}
