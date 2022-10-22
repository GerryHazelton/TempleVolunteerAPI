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
    public class CredentialController : ControllerBase
    {
        private readonly ICredentialService _credentialService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<CredentialRequest>> _collResponse;
        private ServiceResponse<CredentialResponse> _response;

        public CredentialController(ICredentialService CredentialService, IMapper mapper)
        {
            _credentialService = CredentialService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<CredentialRequest>>();
            _response = new ServiceResponse<CredentialResponse>();
        }
    }
}
