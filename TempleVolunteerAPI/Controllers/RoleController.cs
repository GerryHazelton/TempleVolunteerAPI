using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
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
        private ServiceResponse<IList<RoleResponse>> _collResponse;
        private ServiceResponse<RoleResponse> _response;

        public RoleController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<RoleResponse>>();
            _response = new ServiceResponse<RoleResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<RoleResponse>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<RoleResponse>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<RoleResponse>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<RoleResponse>(await _roleService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<RoleResponse>>> PostAsync([FromBody] RoleResponse request)
        {
            if (await _roleService.AddAsync(_mapper.Map<Role>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<RoleResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create Role");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<RoleResponse>>> PutAsync([FromBody] RoleResponse request)
        {
            if (await _roleService.UpdateAsync(_mapper.Map<Role>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<RoleResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update Role");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<RoleResponse>>> DeleteAsync(int id)
        {
            if (await _roleService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<RoleResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete Role");
            }
        }

        private async Task<IList<Role>> ReturnCollection()
        {
            return await _roleService.GetAllAsync();
        }
    }
}
