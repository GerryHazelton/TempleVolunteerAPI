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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IStaffCredentialService _staffCredentialService;
        private readonly ICredentialService _credentialService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<StaffRequest>> _collResponse;
        private ServiceResponse<Staff> _response;
        private bool _result;

        public StaffController(IStaffService StaffService, IMapper mapper, IStaffCredentialService staffCredentialService, ICredentialService credentialService)
        {
            _staffService = StaffService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<StaffRequest>>();
            _response = new ServiceResponse<Staff>();
            _staffCredentialService = staffCredentialService;
            _credentialService = credentialService;
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<StaffRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPost("GetByIdAsync")]
        public ServiceResponse<Staff> GetByIdAsync([FromBody] MiscRequest request)
        {
            var staff = _staffService.FindByCondition(x => x.StaffId == request.GetById && x.PropertyId == request.PropertyId, request.PropertyId, request.UserId, WithDetails.Yes).FirstOrDefault();
            _response.Data = staff;
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<StaffRequest>> PostAsync([FromBody] StaffRequest request)
        {
            Staff staff = _mapper.Map<Staff>(request);
            staff = (Staff)_staffService.Create(staff, request.PropertyId, request.CreatedBy);

            if (request.CredentialIds.Length > 0)
            {
                staff.Credentials = GetCredentials(staff, request.CredentialIds, request.PropertyId, request.CreatedBy);
            }

            _result = _staffService.Update(staff, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<StaffRequest>> PutAsync([FromBody] StaffRequest request)
        {
            Staff staff = _staffService.FindByCondition(x => x.StaffId == request.StaffId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            staff = _mapper.Map<Staff>(request);
            staff.Credentials.Clear();

            var staffCredentials = _staffCredentialService.FindByCondition(x => x.StaffId == staff.StaffId, request.PropertyId, request.UpdatedBy, WithDetails.No).ToList();

            foreach (StaffCredential asi in staffCredentials)
            {
                _staffCredentialService.Delete(asi, request.PropertyId, request.UpdatedBy);
            }

            if (request.CredentialIds.Length > 0)
            {
                staff.Credentials = GetCredentials(staff, request.CredentialIds, request.PropertyId, request.UpdatedBy);
            }

            _result = _staffService.Update(staff, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<StaffRequest>> DeleteAsync(MiscRequest request)
        {
            Staff staff = _staffService.FindByCondition(x => x.StaffId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.Yes).FirstOrDefault();

            _result = _staffService.Delete(staff, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<StaffCredential> GetCredentials(Staff staff, int[] credentialIds, int propertyId, string userId)
        {
            Credential credential;
            StaffCredential addStaffCredential;
            IList<StaffCredential> staffCredentials = new List<StaffCredential>();

            foreach (int credentialId in credentialIds)
            {
                credential = _credentialService.FindByCondition(x => x.CredentialId == credentialId, propertyId, userId, WithDetails.No).FirstOrDefault();
                addStaffCredential = new StaffCredential { Staff = staff, Credential = credential };
                staffCredentials.Add(addStaffCredential);
            }

            return staffCredentials;
        }

        private IList<Staff> ReturnCollection(int propertyId, string userId)
        {
            return _staffService.FindAll(propertyId, userId).ToList();
        }
    }
}
