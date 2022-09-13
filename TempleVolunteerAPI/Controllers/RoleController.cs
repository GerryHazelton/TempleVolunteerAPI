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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<RoleRequest>> _collResponse;
        private ServiceResponse<RoleResponse> _response;

        public RoleController(IRoleService RoleService, IMapper mapper)
        {
            _roleService = RoleService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<RoleRequest>>();
            _response = new ServiceResponse<RoleResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<RoleRequest>>> GetAllAsync([FromBody] MiscRequest request)
        {
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<RoleResponse>> GetByIdAsync(MiscRequest request)
        {
            _response.Data = _mapper.Map<RoleResponse>(await _roleService.GetAsync(request.GetById, request.PropertyId, request.UserId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<RoleRequest>>> PostAsync([FromBody] RoleRequest request)
        {
            await _roleService.AddAsync(_mapper.Map<Role>(request), request.PropertyId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<RoleRequest>>> PutAsync([FromBody] RoleRequest request)
        {
            await _roleService.UpdateAsync(_mapper.Map<Role>(request), request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(await ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<RoleRequest>>> DeleteAsync(MiscRequest request)
        {
            await _roleService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<RoleRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<Role>> ReturnCollection(int RoleId, string userId)
        {
            return await _roleService.GetAllAsync(RoleId, userId);
        }
    }
}
