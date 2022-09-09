using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;
using VolunteerAPI.Domain;

namespace TempleVolunteerAPI.API
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CredentialController : ControllerBase
    {
        private readonly ICredentialService _CredentialService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<CredentialResponse>> _collResponse;
        private ServiceResponse<CredentialResponse> _response;

        public CredentialController(ICredentialService CredentialService, IMapper mapper)
        {
            _CredentialService = CredentialService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<CredentialResponse>>();
            _response = new ServiceResponse<CredentialResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<CredentialResponse>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<CredentialResponse>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<CredentialResponse>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<CredentialResponse>(await _CredentialService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<CredentialResponse>>> PostAsync([FromBody] CredentialResponse request)
        {
            if (await _CredentialService.AddAsync(_mapper.Map<Credential>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<CredentialResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create Credential");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<CredentialResponse>>> PutAsync([FromBody] CredentialResponse request)
        {
            if (await _CredentialService.UpdateAsync(_mapper.Map<Credential>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<CredentialResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update Credential");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<CredentialResponse>>> DeleteAsync(int id)
        {
            if (await _CredentialService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<CredentialResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete Credential");
            }
        }

        private async Task<IList<Credential>> ReturnCollection()
        {
            return await _CredentialService.GetAllAsync();
        }
    }
}
