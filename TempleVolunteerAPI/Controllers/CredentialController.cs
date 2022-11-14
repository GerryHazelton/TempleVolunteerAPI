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
    public class CredentialController : ControllerBase
    {
        private readonly ICredentialService _credentialService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<CredentialRequest>> _collResponse;
        private ServiceResponse<CredentialResponse> _response;
        private bool _result;

        public CredentialController(ICredentialService credentialService, IMapper mapper, ISupplyItemService supplyItemService)
        {
            _credentialService = credentialService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<CredentialRequest>>();
            _response = new ServiceResponse<CredentialResponse>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<CredentialRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<CredentialResponse> GetByIdAsync(int id, int propertyId, string userId)
        {
            Credential credential = _credentialService.FindByCondition(x => x.CredentialId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.No).FirstOrDefault();
            _response.Data = _mapper.Map<CredentialResponse>(credential);
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<CredentialRequest>> PostAsync([FromBody] CredentialRequest request)
        {
            Credential credential = _mapper.Map<Credential>(request);
            credential = (Credential)_credentialService.Create(credential, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = credential != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<CredentialRequest>> PutAsync([FromBody] CredentialRequest request)
        {
            Credential credential = _credentialService.FindByCondition(x => x.CredentialId == request.CredentialId, request.PropertyId, request.UpdatedBy, WithDetails.No).FirstOrDefault();
            credential = _mapper.Map<Credential>(request);

            _result = _credentialService.Update(credential, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _result ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<CredentialRequest>> DeleteAsync(MiscRequest request)
        {
            Credential credential = _credentialService.FindByCondition(x => x.CredentialId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.No).FirstOrDefault();

            _result = _credentialService.Delete(credential, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<Credential> ReturnCollection(int propertyId, string userId)
        {
            return _credentialService.FindAll(propertyId, userId).ToList();
        }
    }
}
