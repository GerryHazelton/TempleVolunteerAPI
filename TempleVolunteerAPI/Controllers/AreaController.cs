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
        private readonly IAreaEventTaskService _areaEventTaskService;
        private readonly IEventTaskService _eventTaskService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<AreaRequest>> _collResponse;
        private ServiceResponse<AreaRequest> _response;
        private bool _result;

        public AreaController(IAreaService AreaService, IMapper mapper, IAreaSupplyItemService areaSupplyItemService, ISupplyItemService supplyItemService, IAreaEventTaskService areaEventTaskService, IEventTaskService eventTaskService)
        {
            _areaService = AreaService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<AreaRequest>>();
            _response = new ServiceResponse<AreaRequest>();
            _areaSupplyItemService = areaSupplyItemService;
            _supplyItemService = supplyItemService;
            _areaEventTaskService = areaEventTaskService;
            _eventTaskService = eventTaskService;
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<AreaRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<AreaRequest> GetByIdAsync(int id, int propertyId, string userId)
        {
            var area = _areaService.FindByCondition(x => x.AreaId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).FirstOrDefault();
            _response.Data = _mapper.Map<AreaRequest>(area);

            if (area.EventTasks.Count > 0)
            {
                _response.Data.EventTaskIds = new int[area.EventTasks.Count];
                for (int i=0; i < area.EventTasks.Count; i++)
                {
                    _response.Data.EventTaskIds[i] = area.EventTasks.ToList()[i].EventTaskId;
                }
            }

            if (area.SupplyItems.Count > 0)
            {
                _response.Data.SupplyItemIds = new int[area.SupplyItems.Count];
                for (int i = 0; i < area.SupplyItems.Count; i++)
                {
                    _response.Data.SupplyItemIds[i] = area.SupplyItems.ToList()[i].SupplyItemId;
                }
            }

            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<AreaRequest>> PostAsync([FromBody] AreaRequest request)
        {
            Area area = _mapper.Map<Area>(request);
            area = (Area)_areaService.Create(area, request.PropertyId, request.CreatedBy);

            if (request.EventTaskIds.Length > 0)
            {
                area.EventTasks = GetEventTasks(area, request.EventTaskIds, request.PropertyId, request.CreatedBy);
            }

            if (request.SupplyItemIds.Length > 0)
            {
                area.SupplyItems = GetSupplyItems(area, request.SupplyItemIds, request.PropertyId, request.CreatedBy);
            }

            _result = _areaService.Update(area, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<AreaRequest>> PutAsync([FromBody] AreaRequest request)
        {
            Area area = _areaService.FindByCondition(x => x.AreaId == request.AreaId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            area = _mapper.Map<Area>(request);
            
            if (area.SupplyItems != null && area.SupplyItems.Count > 0)
            {
                area.SupplyItems.Clear();
            }

            if (area.EventTasks != null && area.EventTasks.Count > 0)
            {
                area.EventTasks.Clear();
            }

            var areaSupplyItems = _areaSupplyItemService.FindByCondition(x => x.AreaId == area.AreaId, request.PropertyId, request.UpdatedBy, WithDetails.No).ToList();

            foreach (AreaSupplyItem asi in areaSupplyItems)
            {
                _areaSupplyItemService.Delete(asi, request.PropertyId, request.UpdatedBy);
            }

            if (request.EventTaskIds.Length > 0)
            {
                area.EventTasks = GetEventTasks(area, request.EventTaskIds, request.PropertyId, request.CreatedBy);
            }

            var areaEventTasks = _areaEventTaskService.FindByCondition(x => x.AreaId == area.AreaId, request.PropertyId, request.UpdatedBy, WithDetails.No).ToList();

            foreach (AreaEventTask aet in areaEventTasks)
            {
                _areaEventTaskService.Delete(aet, request.PropertyId, request.UpdatedBy);
            }

            if (request.EventTaskIds.Length > 0)
            {
                area.EventTasks = GetEventTasks(area, request.EventTaskIds, request.PropertyId, request.UpdatedBy);
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

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<AreaRequest>> DeleteAsync(int areaId, int propertyId, string userId)
        {
            Area area = _areaService.FindByCondition(x => x.AreaId == areaId, propertyId, userId, WithDetails.Yes).FirstOrDefault();

            _result = _areaService.Delete(area, propertyId, userId);
            _collResponse.Data = _mapper.Map<IList<AreaRequest>>(ReturnCollection(propertyId, userId));
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
                supplyItem = _supplyItemService.FindByCondition(x => x.SupplyItemId == supplyItemId, propertyId, userId, WithDetails.No).FirstOrDefault();
                addAreaSupplyItem = new AreaSupplyItem { Area = area, SupplyItem = supplyItem };
                areaSupplyItems.Add(addAreaSupplyItem);
            }

            return areaSupplyItems;
        }

        private IList<AreaEventTask> GetEventTasks(Area area, int[] eventTaskIds, int propertyId, string userId)
        {
            EventTask eventTask;
            AreaEventTask addAreaEventTask;
            IList<AreaEventTask> areaEventTasks = new List<AreaEventTask>();

            foreach (int eventTaskId in eventTaskIds)
            {
                eventTask = _eventTaskService.FindByCondition(x => x.EventTaskId == eventTaskId, propertyId, userId, WithDetails.No).FirstOrDefault();
                addAreaEventTask = new AreaEventTask { Area = area, EventTask = eventTask };
                areaEventTasks.Add(addAreaEventTask);
            }

            return areaEventTasks;
        }

        private IList<Area> ReturnCollection(int propertyId, string userId)
        {
            return _areaService.FindAll(propertyId, userId).ToList();
        }
    }
}
