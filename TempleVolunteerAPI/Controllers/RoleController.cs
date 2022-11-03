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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<RoleRequest>> _collResponse;
        private ServiceResponse<RoleResponse> _response;
        private bool _result;

        public RoleController(IRoleService roleService, IMapper mapper, ISupplyItemService supplyItemService)
        {
            _roleService = roleService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<RoleRequest>>();
            _response = new ServiceResponse<RoleResponse>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<RoleRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<RoleResponse> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<RoleResponse>(_roleService.FindByCondition(x => x.RoleId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.No));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<RoleRequest>> PostAsync([FromBody] RoleRequest request)
        {
            Role role = _mapper.Map<Role>(request);
            role = (Role)_roleService.Create(role, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = role != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<RoleRequest>> PutAsync([FromBody] RoleRequest request)
        {
            Role role = _roleService.FindByCondition(x => x.RoleId == request.RoleId, request.PropertyId, request.UpdatedBy, WithDetails.No).FirstOrDefault();
            role = _mapper.Map<Role>(request);

            _result = _roleService.Update(role, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _result ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<RoleRequest>> DeleteAsync(MiscRequest request)
        {
            Role role = _roleService.FindByCondition(x => x.RoleId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.No).FirstOrDefault();

            _result = _roleService.Delete(role, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<Role> ReturnCollection(int propertyId, string userId)
        {
            return _roleService.FindAll(propertyId, userId).ToList();
        }
    }
}
