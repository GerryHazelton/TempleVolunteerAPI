using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Domain;
using System.Text;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using TempleVolunteerAPI.Domain.DTO;
using AutoMapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TempleVolunteerAPI.Repository
{
    public class StaffRepository : RepositoryBase<Staff>, IStaffRepository
    {
        private readonly RepositoryResponse<Staff> _repositoryResponse;
        private readonly RepositoryResponse<MyProfileRequest> _myProfileRepositoryResponse;
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;

        public StaffRepository(ApplicationDBContext context, IMapper mapper)
            : base(context)
        {
            _repositoryResponse = new RepositoryResponse<Staff>();
            _myProfileRepositoryResponse = new RepositoryResponse<MyProfileRequest>();
            _context = context;
            _mapper = mapper;
        }

        public async Task<RepositoryResponse<Staff>> CustomSqlProcessAsync(Staff request)
        {
            try
            {
                Staff update = request;
                StringBuilder sbSql = new StringBuilder("UPDATE Staff SET ");
                Staff updateStaff = await _context.Staff.FindAsync(update.StaffId);

                if (!updateStaff.FirstName.ToLower().Trim().Equals(update.FirstName.ToLower().Trim())) sbSql.AppendFormat("FirstName = '{0}', ", update.FirstName);
                if (!updateStaff.LastName.ToLower().Trim().Equals(update.LastName.ToLower().Trim())) sbSql.AppendFormat("LastName = '{0}', ", update.LastName);
                if (!updateStaff.Address.ToLower().Trim().Equals(update.Address.ToLower().Trim())) sbSql.AppendFormat("Address = '{0}', ", update.Address);
                if (updateStaff.Address2 == null && updateStaff.Address2 != update.Address2) sbSql.AppendFormat("Address2 = '{0}', ", update.Address2);
                if (updateStaff.Address2 != null && !updateStaff.Address2.Equals(update.Address2)) sbSql.AppendFormat("Address2 = '{0}', ", update.Address2);
                if (!updateStaff.City.ToLower().Trim().Equals(update.City.ToLower().Trim())) sbSql.AppendFormat("City = '{0}', ", update.City);
                if (!updateStaff.State.ToLower().Trim().Equals(update.State.ToLower().Trim())) sbSql.AppendFormat("State = '{0}', ", update.State);
                if (!updateStaff.PostalCode.ToLower().Trim().Equals(update.PostalCode.ToLower().Trim())) sbSql.AppendFormat("PostalCode = '{0}', ", update.PostalCode);
                if (!updateStaff.Country.ToLower().Trim().Equals(update.Country.ToLower().Trim())) sbSql.AppendFormat("Country = '{0}', ", update.Country);
                if (!updateStaff.Gender.ToLower().Trim().Equals(update.Gender.ToLower().Trim())) sbSql.AppendFormat("Gender = '{0}', ", update.Gender);
                //if (!updateStaff.Role.Equals(update.Role)) sbSql.AppendFormat("Role = '{0}', ", update.Role);
                if (!updateStaff.EmailAddress.ToLower().Trim().Equals(update.EmailAddress.ToLower().Trim())) sbSql.AppendFormat("EmailAddress = '{0}', ", update.EmailAddress);
                if (!updateStaff.PhoneNumber.ToLower().Trim().Equals(update.PhoneNumber.ToLower().Trim())) sbSql.AppendFormat("PhoneNumber = '{0}', ", update.PhoneNumber);
                if (!updateStaff.FirstAid.Equals(update.FirstAid)) sbSql.AppendFormat("FirstAid = {0}, ", update.FirstAid == true ? 1 : 0);
                if (!updateStaff.CPR.Equals(update.CPR)) sbSql.AppendFormat("CPR = {0}, ", update.CPR == true ? 1 : 0);
                if (!updateStaff.Kriyaban.Equals(update.Kriyaban)) sbSql.AppendFormat("Kriyaban = {0}, ", update.Kriyaban == true ? 1 : 0);
                if (!updateStaff.LessonStudent.Equals(update.LessonStudent)) sbSql.AppendFormat("LessonStudent = {0}, ", update.LessonStudent == true ? 1 : 0);
                if (updateStaff.Note == null && updateStaff.Note != update.Note) sbSql.AppendFormat("Notes = '{0}', ", update.Note);
                if (updateStaff.Note != null && !updateStaff.Note.Equals(update.Note)) sbSql.AppendFormat("Notes = '{0}', ", update.Note);
                if (updateStaff.StaffFileName == null && updateStaff.StaffFileName != update.StaffFileName) sbSql.AppendFormat("StaffFileName = '{0}', ", update.StaffFileName);

                if (updateStaff.StaffImage != null && updateStaff.StaffImage != update.StaffImage)
                {
                    string base64 = Convert.ToBase64String(update.StaffImage, 0, update.StaffImage.Length);
                    byte[]? imageBytes = Convert.FromBase64String(base64);
                    sbSql.AppendFormat("StaffImage = CONVERT(VARBINARY(MAX), '{0}'), ", base64);
                }

                if (!updateStaff.RememberMe.Equals(update.RememberMe)) sbSql.AppendFormat("RememberMe = {0}, ", update.RememberMe);

                if (update.UnlockUser)
                {
                    sbSql.AppendFormat("IsLockedOut = {0}, ", 0);
                    sbSql.AppendFormat("LoginAttempts = {0}, ", 0);
                }

                if (!updateStaff.LoginAttempts.Equals(update.LoginAttempts)) sbSql.AppendFormat("LoginAttempts = {0}, ", update.LoginAttempts);
                if (!updateStaff.IsActive.Equals(update.IsActive)) sbSql.AppendFormat("IsActive = {0}, ", update.IsActive);
                if (!updateStaff.IsVerified.Equals(update.IsVerified)) sbSql.AppendFormat("IsVerified = {0}, ", update.IsVerified);

                if (sbSql.ToString().TrimEnd().Length == 16)
                {
                    _repositoryResponse.Result = true;
                }

                sbSql = new StringBuilder(sbSql.ToString().Substring(0, sbSql.ToString().Length - 2));
                sbSql.AppendFormat(" WHERE StaffId = {0}", update.StaffId);
                await _context.Database.ExecuteSqlRawAsync(sbSql.ToString());
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<MyProfileRequest>> CustomMyProfileUpdateAsync(MyProfileRequest request)
        {
            try
            {
                StringBuilder sbSql = new StringBuilder("UPDATE Staff\n");
                sbSql.Append("SET ");
                var originalStaff = await _context.Staff.FirstAsync(x => x.EmailAddress == request.EmailAddress && x.PropertyId == request.PropertyId);

                if (originalStaff == null)
                {
                    _myProfileRepositoryResponse.Error = new Exception("User not found.");
                    return _myProfileRepositoryResponse;
                }

                if (!originalStaff.FirstName.ToLower().Trim().Equals(request.FirstName.ToLower().Trim())) sbSql.AppendFormat("FirstName = '{0}', ", request.FirstName);
                if (!originalStaff.LastName.ToLower().Trim().Equals(request.LastName.ToLower().Trim())) sbSql.AppendFormat("LastName = '{0}', ", request.LastName);
                if (!originalStaff.Address.ToLower().Trim().Equals(request.Address.ToLower().Trim())) sbSql.AppendFormat("Address = '{0}', ", request.Address);
                if (!originalStaff.Address2.ToLower().Trim().Equals(request.Address2.ToLower().Trim())) sbSql.AppendFormat("Address2 = '{0}', ", request.Address2);
                if (!originalStaff.City.ToLower().Trim().Equals(request.City.ToLower().Trim())) sbSql.AppendFormat("City = '{0}', ", request.City);
                if (!originalStaff.State.ToLower().Trim().Equals(request.State.ToLower().Trim())) sbSql.AppendFormat("State = '{0}', ", request.State);
                if (!originalStaff.PostalCode.ToLower().Trim().Equals(request.PostalCode.ToLower().Trim())) sbSql.AppendFormat("PostalCode = '{0}', ", request.PostalCode);
                if (!originalStaff.Country.ToLower().Trim().Equals(request.Country.ToLower().Trim())) sbSql.AppendFormat("Country = '{0}', ", request.Country);
                if (!originalStaff.EmailAddress.ToLower().Trim().Equals(request.EmailAddress.ToLower().Trim())) sbSql.AppendFormat("EmailAddress = '{0}', ", request.EmailAddress);
                if (!originalStaff.PhoneNumber.ToLower().Trim().Equals(request.PhoneNumber.ToLower().Trim())) sbSql.AppendFormat("PhoneNumber = '{0}', ", request.PhoneNumber);
                if (!originalStaff.Gender.ToLower().Trim().Equals(request.Gender.ToLower().Trim())) sbSql.AppendFormat("Gender = '{0}', ", request.Gender);
                if (!originalStaff.FirstAid.Equals(request.FirstAid)) sbSql.AppendFormat("FirstAid = {0}, ", request.FirstAid == true ? 1 : 0);
                if (!originalStaff.CPR.Equals(request.CPR)) sbSql.AppendFormat("CPR = {0}, ", request.CPR == true ? 1 : 0);
                if (!originalStaff.Kriyaban.Equals(request.Kriyaban)) sbSql.AppendFormat("Kriyaban = {0}, ", request.Kriyaban == true ? 1 : 0);
                if (!originalStaff.LessonStudent.Equals(request.LessonStudent)) sbSql.AppendFormat("LessonStudent = {0}, ", request.LessonStudent == true ? 1 : 0);

                sbSql.AppendFormat("UpdatedBy = '{0}', ", request.UpdatedBy);
                sbSql.AppendFormat("UpdatedDate = '{0}', ", request.UpdatedDate);

                if (!String.IsNullOrEmpty(request.StaffFileName) && !String.IsNullOrEmpty(originalStaff.StaffFileName))
                {
                    if (!request.StaffFileName.Equals(originalStaff.StaffFileName))
                    {
                        sbSql.AppendFormat("StaffFileName = '{0}', ", request.StaffFileName);
                    }
                } else if (!String.IsNullOrEmpty(request.StaffFileName) && String.IsNullOrEmpty(originalStaff.StaffFileName))
                {
                    sbSql.AppendFormat("StaffFileName = '{0}', ", request.StaffFileName);
                } else
                {
                    sbSql.AppendFormat("StaffFileName = '{0}', ", DBNull.Value);
                }

                if (request.StaffImage != null && originalStaff.StaffImage != null)
                {
                    if (!request.StaffImage.Equals(originalStaff.StaffImage))
                    {
                        string base64 = Convert.ToBase64String(request.StaffImage, 0, request.StaffImage.Length);
                        byte[]? imageBytes = Convert.FromBase64String(base64);
                        sbSql.AppendFormat("StaffImage = CONVERT(VARBINARY(MAX), '{0}'), ", base64);
                    }
                }
                else if (request.StaffImage != null && originalStaff.StaffImage == null)
                {
                    string base64 = Convert.ToBase64String(request.StaffImage, 0, request.StaffImage.Length);
                    byte[]? imageBytes = Convert.FromBase64String(base64);
                    sbSql.AppendFormat("StaffImage = CONVERT(VARBINARY(MAX), '{0}'), ", base64);
                }

                sbSql = new StringBuilder(sbSql.ToString().Substring(0, sbSql.ToString().Length - 2));
                sbSql.AppendFormat("\nWHERE EmailAddress = '{0}' AND PropertyId = {1}", request.EmailAddress, request.PropertyId);
                await _context.Database.ExecuteSqlRawAsync(sbSql.ToString());
                Staff updatedStaff = await _context.Staff.FirstAsync(x => x.EmailAddress == request.EmailAddress && x.PropertyId == request.PropertyId);
                _myProfileRepositoryResponse.Entity = _mapper.Map<MyProfileRequest>(updatedStaff);
            }
            catch (Exception ex)
            {
                _myProfileRepositoryResponse.Error = ex;
            }

            return _myProfileRepositoryResponse;
        }
    }
}
