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
    }
}
