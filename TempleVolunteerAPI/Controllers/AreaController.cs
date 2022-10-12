﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            _response.Data = _mapper.Map<AreaResponse>(await _areaService.GetByIdAsync(id, propertyId, userId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<AreaRequest>>> PostAsync([FromBody] AreaRequest request)
        {
            Area area = _mapper.Map<Area>(request);

            if (request.SupplyItemIds.Length > 0)
            {
                area.AreasSupplyItems = await GetAreaSupplyItems(request.SupplyItemIds, request.PropertyId, request.CreatedBy);
            }

            await _areaService.AddAsync(area, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<AreaRequest>>> PutAsync([FromBody] AreaRequest request)
        {
            Area area = await _areaService.GetByIdAsync(request.AreaId, request.PropertyId, request.UpdatedBy);

            IList<AreaSupplyItem> areasSupplyItems = await _areaSupplyItemService.FindAllAsync(x=>x.AreaId == area.AreaId);
            
            if (areasSupplyItems.Count > 0)
            {
                area.AreasSupplyItems = areasSupplyItems;
                area.AreasSupplyItems.Clear();
            }

            if (request.SupplyItemIds.Length > 0)
            {
                area.AreasSupplyItems = await GetAreaSupplyItems(request.SupplyItemIds, request.PropertyId, request.UpdatedBy);
            }

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

        private async Task<IList<AreaSupplyItem>> GetAreaSupplyItems(int[] supplyItemIds, int propertyId, string userId)
        {
            SupplyItem supplyItem;
            AreaSupplyItem addAreaSupplyItem;
            IList<AreaSupplyItem> areasSupplyItems = new List<AreaSupplyItem>();

            foreach (int supplyItemId in supplyItemIds)
            {
                supplyItem = await _supplyItemService.GetByIdAsync(supplyItemId, propertyId, userId);
                addAreaSupplyItem = new AreaSupplyItem { SupplyItem = supplyItem, SupplyItemId = supplyItem.SupplyItemId };
                areasSupplyItems.Add(addAreaSupplyItem);
            }

            return areasSupplyItems;
        }

        private async Task<IList<Area>> ReturnCollection(int propertyId, string userId)
        {
            return await _areaService.GetAllAsync(propertyId, userId);
        }
    }
}
