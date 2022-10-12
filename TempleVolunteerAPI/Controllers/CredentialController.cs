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

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<CredentialRequest>>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(await ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<CredentialResponse>> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<CredentialResponse>(await _credentialService.GetByIdAsync(id, propertyId, userId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<CredentialRequest>>> PostAsync([FromBody] CredentialRequest request)
        {
            await _credentialService.AddAsync(_mapper.Map<Credential>(request), request.PropertyId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<CredentialRequest>>> PutAsync([FromBody] CredentialRequest request)
        {
            await _credentialService.UpdateAsync(_mapper.Map<Credential>(request), request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(await ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<CredentialRequest>>> DeleteAsync(MiscRequest request)
        {
            await _credentialService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<Credential>> ReturnCollection(int propertyId, string userId)
        {
            return await _credentialService.GetAllAsync(propertyId, userId);
        }
    }
}
