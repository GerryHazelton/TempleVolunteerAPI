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
    public class CredentialController : ControllerBase
    {
        private readonly ICredentialService _credentialService;
        private readonly ISupplyItemService _supplyItemService;
        private readonly IEventTaskService _eventTaskService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<CredentialRequest>> _collResponse;
        private ServiceResponse<CredentialRequest> _response;
        private bool _result;

        public CredentialController(ICredentialService CredentialService, IMapper mapper)
        {
            _credentialService = CredentialService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<CredentialRequest>>();
            _response = new ServiceResponse<CredentialRequest>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<CredentialRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<CredentialRequest> GetByIdAsync(int id, int propertyId, string userId)
        {
            var credential = _credentialService.FindByCondition(x => x.CredentialId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).FirstOrDefault();
            _response.Data = _mapper.Map<CredentialRequest>(credential);
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<CredentialRequest>> PostAsync([FromBody] CredentialRequest request)
        {
            Credential credential = _mapper.Map<Credential>(request);
            credential = (Credential)_credentialService.Create(credential, request.PropertyId, request.CreatedBy);
            //_result = _credentialService.Update(credential, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = credential != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<CredentialRequest>> PutAsync([FromBody] CredentialRequest request)
        {
            Credential credential = _credentialService.FindByCondition(x => x.CredentialId == request.CredentialId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            credential = _mapper.Map<Credential>(request);

            _result = _credentialService.Update(credential, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<CredentialRequest>> DeleteAsync(int credentialId, int propertyId, string userId)
        {
            Credential credential = _credentialService.FindByCondition(x => x.CredentialId == credentialId, propertyId, userId, WithDetails.Yes).FirstOrDefault();

            _result = _credentialService.Delete(credential, propertyId, userId);
            _collResponse.Data = _mapper.Map<IList<CredentialRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<Credential> ReturnCollection(int propertyId, string userId)
        {
            return _credentialService.FindAll(propertyId, userId).ToList();
        }
    }
}
