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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<StaffRequest>> _collResponse;
        private ServiceResponse<StaffRequest> _response;

        public StaffController(IStaffService StaffService, IMapper mapper)
        {
            _staffService = StaffService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<StaffRequest>>();
            _response = new ServiceResponse<StaffRequest>();
        }
    }
}
