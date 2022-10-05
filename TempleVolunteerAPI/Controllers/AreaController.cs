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
    public class AreaController : ControllerBase
    {
        private readonly IAreaService _areaService;
        private readonly IAreaSupplyItemService _areaSupplyItemService;
        private readonly ISupplyItemService _supplyItemService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<AreaRequest>> _collResponse;
        private ServiceResponse<AreaResponse> _response;

        public AreaController(IAreaService AreaService, IMapper mapper, IAreaSupplyItemService areaSupplyItemService, ISupplyItemService supplyItemService)
        {
            _areaService = AreaService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<AreaRequest>>();
            _response = new ServiceResponse<AreaResponse>();
            _areaSupplyItemService = areaSupplyItemService;
            _supplyItemService = supplyItemService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<AreaRequest>>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(await ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<AreaResponse>> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<AreaResponse>(await _areaService.GetAsync(id, propertyId, userId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<AreaRequest>>> PostAsync([FromBody] AreaRequest request)
        {
            if (request.SupplyItemIds.Length > 0)
            {
                IList<SupplyItem> supplyItems = await _supplyItemService.GetAllAsync(request.PropertyId, request.CreatedBy);
                Area area = _mapper.Map<Area>(request);

                foreach (int supplyItem in request.SupplyItemIds)
                {
                    area.SupplyItems.Add((SupplyItemRequest)items.Where(x => x.SupplyItemId == item).FirstOrDefault());
                }
            }


            await _areaService.AddAsync(_mapper.Map<Area>(request), request.PropertyId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<AreaRequest>>> PutAsync([FromBody] AreaRequest request)
        {
            await _areaService.UpdateAsync(_mapper.Map<Area>(request), request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(await ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<AreaRequest>>> DeleteAsync(MiscRequest request)
        {
            await _areaService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<Area>> ReturnCollection(int propertyId, string userId)
        {
            return await _areaService.GetAllAsync(propertyId, userId);
        }
    }
}
