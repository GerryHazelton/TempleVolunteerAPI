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
    public class AreaController : ControllerBase
    {
        private readonly IAreaService _areaService;
        private readonly IAreaSupplyItemService _areaSupplyItemService;
        private readonly ISupplyItemService _supplyItemService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<AreaRequest>> _collResponse;
        private ServiceResponse<AreaResponse> _response;
        private bool _result;

        public AreaController(IAreaService AreaService, IMapper mapper, IAreaSupplyItemService areaSupplyItemService, ISupplyItemService supplyItemService)
        {
            _areaService = AreaService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<AreaRequest>>();
            _response = new ServiceResponse<AreaResponse>();
            _areaSupplyItemService = areaSupplyItemService;
            _supplyItemService = supplyItemService;
        }

        [HttpGet("GetAll")]
        public ServiceResponse<IList<AreaRequest>> GetAll(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetById")]
        public ServiceResponse<AreaResponse> GetById(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<AreaResponse>(_areaService.FindByCondition(x=>x.AreaId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.None));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("Post")]
        public ServiceResponse<IList<AreaRequest>> Post([FromBody] AreaRequest request)
        {
            Area area = _mapper.Map<Area>(request);
            area = (Area)_areaService.Create(area, request.PropertyId, request.CreatedBy);

            if (request.SupplyItemIds.Length > 0)
            {
                area.SupplyItems = GetSupplyItems(area, request.SupplyItemIds, request.PropertyId, request.CreatedBy);
            }

            _result = _areaService.Update(area, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("Put")]
        public ServiceResponse<IList<AreaRequest>> Put([FromBody] AreaRequest request)
        {
            Area area = _areaService.FindByCondition(x => x.AreaId == request.AreaId, request.PropertyId, request.UpdatedBy, WithDetails.AreaSupplyItem).FirstOrDefault();
            area = _mapper.Map<Area>(request);
            area.SupplyItems.Clear();

            var areaSupplyItems = _areaSupplyItemService.FindByCondition(x => x.AreaId == area.AreaId, request.PropertyId, request.UpdatedBy, WithDetails.None).ToList();

            foreach (AreaSupplyItem asi in areaSupplyItems)
            {
                _areaSupplyItemService.Delete(asi, request.PropertyId, request.UpdatedBy);
            }

            if (request.SupplyItemIds.Length > 0)
            {
                area.SupplyItems = GetSupplyItems(area, request.SupplyItemIds, request.PropertyId, request.UpdatedBy);
            }

            _result = _areaService.Update(area, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("Delete")]
        public ServiceResponse<IList<AreaRequest>> Delete(MiscRequest request)
        {
            Area area = _areaService.FindByCondition(x => x.AreaId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.AreaSupplyItem).FirstOrDefault();

            _result = _areaService.Delete(area, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<AreaSupplyItem> GetSupplyItems(Area area, int[] supplyItemIds, int propertyId, string userId)
        {
            SupplyItem supplyItem;
            AreaSupplyItem addAreaSupplyItem;
            IList<AreaSupplyItem> areaSupplyItems = new List<AreaSupplyItem>();

            foreach (int supplyItemId in supplyItemIds)
            {
                supplyItem = _supplyItemService.FindByCondition(x=>x.SupplyItemId == supplyItemId, propertyId, userId, WithDetails.None).FirstOrDefault();
                addAreaSupplyItem = new AreaSupplyItem { Area = area, SupplyItem = supplyItem };
                areaSupplyItems.Add(addAreaSupplyItem);
            }

            return areaSupplyItems;
        }

        private IList<Area> ReturnCollection(int propertyId, string userId)
        {
            return _areaService.FindAll(propertyId, userId).ToList();
        }
    }
}
