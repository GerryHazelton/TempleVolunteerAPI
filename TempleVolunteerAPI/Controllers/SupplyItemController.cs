using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
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
        private ServiceResponse<SupplyItemResponse> _response;
        private bool _result;

        public SupplyItemController(ISupplyItemService SupplyItemService, IMapper mapper, ISupplyItemService supplyItemService)
        {
            _supplyItemService = SupplyItemService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<SupplyItemRequest>>();
            _response = new ServiceResponse<SupplyItemResponse>();
        }

        [HttpGet("GetAll")]
        public ServiceResponse<IList<SupplyItemRequest>> GetAll(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetById")]
        public ServiceResponse<SupplyItemResponse> GetById(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<SupplyItemResponse>(_supplyItemService.FindByCondition(x => x.SupplyItemId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.None));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("Post")]
        public ServiceResponse<IList<SupplyItemRequest>> Post([FromBody] SupplyItemRequest request)
        {
            SupplyItem supplyItem = _mapper.Map<SupplyItem>(request);

            supplyItem = _supplyItemService.Create(supplyItem, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = supplyItem != null ? true : false;

            return _collResponse;
        }

        [HttpPut("Put")]
        public ServiceResponse<IList<SupplyItemRequest>> Put([FromBody] SupplyItemRequest request)
        {
            SupplyItem supplyItem = _mapper.Map<SupplyItem>(request);
            _result = _supplyItemService.Update(supplyItem, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("Delete")]
        public ServiceResponse<IList<SupplyItemRequest>> Delete(MiscRequest request)
        {
            SupplyItem supplyItem = _supplyItemService.FindByCondition(x => x.SupplyItemId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.None).FirstOrDefault();

            _result = _supplyItemService.Delete(supplyItem, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<SupplyItemRequest>>(ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }
        private IList<SupplyItem> ReturnCollection(int propertyId, string userId)
        {
            return _supplyItemService.FindAll(propertyId, userId).ToList();
        }
    }
}
