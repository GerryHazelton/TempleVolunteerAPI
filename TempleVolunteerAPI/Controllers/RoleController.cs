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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<RoleRequest>> _collResponse;
        private ServiceResponse<RoleRequest> _response;
        private bool _result;

        public RoleController(IRoleService RoleService, IMapper mapper)
        {
            _roleService = RoleService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<RoleRequest>>();
            _response = new ServiceResponse<RoleRequest>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<RoleRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<RoleRequest> GetByIdAsync(int id, int propertyId, string userId)
        {
            var role = _roleService.FindByCondition(x => x.RoleId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).FirstOrDefault();
            _response.Data = _mapper.Map<RoleRequest>(role);
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<RoleRequest>> PostAsync([FromBody] RoleRequest request)
        {
            Role role = _mapper.Map<Role>(request);
            role = (Role)_roleService.Create(role, request.PropertyId, request.CreatedBy);
            _result = _roleService.Update(role, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<RoleRequest>> PutAsync([FromBody] RoleRequest request)
        {
            Role role = _roleService.FindByCondition(x => x.RoleId == request.RoleId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            role = _mapper.Map<Role>(request);

            _result = _roleService.Update(role, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<RoleRequest>> DeleteAsync(int roleId, int propertyId, string userId)
        {
            Role role = _roleService.FindByCondition(x => x.RoleId == roleId, propertyId, userId, WithDetails.Yes).FirstOrDefault();

            _result = _roleService.Delete(role, propertyId, userId);
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<Role> ReturnCollection(int propertyId, string userId)
        {
            return _roleService.FindAll(propertyId, userId).ToList();
        }
    }
}
