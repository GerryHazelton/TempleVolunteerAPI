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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IAccountService _accountService;
        private readonly IGeneralService _generalService;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<StaffRequest>> _collResponse;
        private ServiceResponse<IList<StaffEmailCheckRequest>> _collEmailCheckResponse;
        private ServiceResponse<StaffRequest> _response;
        private bool _result;

        public StaffController(IStaffService staffService, IGeneralService generalService, IAccountService accountService, IEmailService emailService, IMapper mapper)
        {
            _staffService = staffService;
            _generalService = generalService;
            _accountService = accountService;
            _emailService = emailService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<StaffRequest>>();
            _collEmailCheckResponse = new ServiceResponse<IList<StaffEmailCheckRequest>>();
            _response = new ServiceResponse<StaffRequest>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<StaffRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse = ReturnCollection(propertyId, userId);

            return _collResponse;
        }

        [HttpGet("GetAllStaffEmailAsync")]
        public ServiceResponse<IList<StaffEmailCheckRequest>> GetAllStaffEmailAsync(int propertyId, string userId)
        {
            _collEmailCheckResponse.Data = _mapper.Map<IList<StaffEmailCheckRequest>>(ReturnEmailCheckCollection(propertyId, userId));
            _collEmailCheckResponse.Success = _collResponse.Data != null ? true : false;

            return _collEmailCheckResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<StaffRequest> GetByIdAsync(int id, int propertyId, string userId)
        {
            var staff = _staffService.FindByCondition(x => x.StaffId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).FirstOrDefault();
            _response.Data = _mapper.Map<StaffRequest>(staff);

            if (staff.Credentials.Count > 0)
            {
                _response.Data.CredentialIds = new int[staff.Credentials.Count];
                for (int i = 0; i < staff.Credentials.Count; i++)
                {
                    _response.Data.CredentialIds[i] = staff.Credentials.ToList()[i].CredentialId;
                }
            }

            if (staff.Roles.Count > 0)
            {
                _response.Data.RoleIds = new int[staff.Roles.Count];
                for (int i = 0; i < staff.Roles.Count; i++)
                {
                    _response.Data.RoleIds[i] = staff.Roles.ToList()[i].RoleId;
                }
            }

            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<StaffRequest>> PostAsync([FromBody] StaffRequest request)
        {
            Staff staff = _mapper.Map<Staff>(request);
            staff = (Staff)_staffService.Create(staff, request.PropertyId, request.CreatedBy);
            _result = _staffService.Update(staff, request.PropertyId, request.CreatedBy);
            _collResponse = ReturnCollection(request.PropertyId, request.CreatedBy);
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<StaffRequest>> PutAsync([FromBody] StaffRequest request)
        {
            Staff staff = _staffService.FindByCondition(x => x.StaffId == request.StaffId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            
            if (!staff.NewRegistration && request.EmailAddress != null)
            {
                staff = _mapper.Map<Staff>(request);

                if (request.RemovePhoto)
                {
                    var general = _generalService.FindAll(request.PropertyId, request.EmailAddress);
                    var gender = general.Where(x => x.Gender == request.Gender).FirstOrDefault();

                    staff.StaffFileName = general.Where(x => x.Gender == request.Gender).FirstOrDefault().Gender == "Male" ? "Male.png" : "Female.png";
                    staff.StaffImage = general.Where(x => x.Gender == request.Gender).FirstOrDefault().MissingImage;
                }

                if (request.CredentialIds == null)
                {
                    request.CredentialIds = new int[0];
                }

                if (request.RoleIds == null)
                {
                    request.RoleIds = new int[0];
                }

                _staffService.CustomStaffUpdate(staff, request.CredentialIds, request.RoleIds);
            }

            request.Approve = request.Approve == null ? false : request.Approve;

            if (staff.NewRegistration && (bool)request.Approve)
            {
                string tempPwd = _accountService.GetTemporaryPassword(staff.StaffId);
                staff.Password = tempPwd;
                _emailService.SendEmail(staff, EmailTypeEnum.RegistrationApproved);
                staff.NewRegistrationApproved = true;
                _staffService.CustomStaffUpdate(staff, request.CredentialIds, request.RoleIds);
            }
            else if (staff.NewRegistration && !(bool)request.Approve)
            {
                DeleteAsync(staff.StaffId, staff.PropertyId, request.UpdatedBy);
            }

            _collResponse = ReturnCollection(request.PropertyId, request.UpdatedBy);

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<StaffRequest>> DeleteAsync(int staffId, int propertyId, string userId)
        {
            Staff staff = _staffService.FindByCondition(x => x.StaffId == staffId, propertyId, userId, WithDetails.Yes).FirstOrDefault();

            _result = _staffService.Delete(staff, propertyId, userId);
            _collResponse = ReturnCollection(propertyId, userId);

            return _collResponse;
        }

        private ServiceResponse<IList<StaffRequest>> ReturnCollection(int propertyId, string userId)
        {
            List<Staff> staffList = _staffService.FindByCondition(x => x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).ToList();
            _collResponse.Data = new List<StaffRequest>();
            int listCtr = 0;

            foreach(Staff staff in staffList)
            {
                _collResponse.Data.Add(_mapper.Map<StaffRequest>(staff));
                if (staff.Credentials.Count > 0)
                {
                    _collResponse.Data[listCtr].CredentialIds = new int[staff.Credentials.Count];
                    for (int i = 0; i < staff.Credentials.Count; i++)
                    {
                        _collResponse.Data[listCtr].CredentialIds[i] = staff.Credentials.ToList()[i].CredentialId;
                    }
                }

                if (staff.Roles.Count > 0)
                {
                    _collResponse.Data[listCtr].RoleIds = new int[staff.Roles.Count];
                    for (int i = 0; i < staff.Roles.Count; i++)
                    {
                        _collResponse.Data[listCtr].RoleIds[i] = staff.Roles.ToList()[i].RoleId;
                    }
                }

                listCtr++;
            }

            _collResponse.Success = _collResponse.Data != null ? true : false;
            return _collResponse;
        }

        private IList<StaffEmailCheckRequest> ReturnEmailCheckCollection(int propertyId, string userId)
        {
            List<StaffEmailCheckRequest> emailList = new List<StaffEmailCheckRequest>();
            var list = _staffService.FindAll(propertyId, userId).ToList();

            if (list.Count > 0)
            {
                foreach(Staff staff in list.ToList())
                {
                    emailList.Add(new StaffEmailCheckRequest {StaffId = staff.StaffId, FirstName = staff.FirstName, MiddleName = staff.MiddleName, LastName = staff.LastName, EmailAddress = staff.EmailAddress });
                }

                return emailList;
            }
            else
            {
                return emailList;
            }
        }
    }
}
