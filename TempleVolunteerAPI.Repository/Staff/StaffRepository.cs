using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Domain;
using System.Text;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using TempleVolunteerAPI.Domain.DTO;
using AutoMapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Linq.Expressions;
using static TempleVolunteerAPI.Common.EnumHelper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Diagnostics;

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
                Staff originalStaff = await _context.Staff.FindAsync(update.StaffId);

                if (!originalStaff.FirstName.ToLower().Trim().Equals(update.FirstName.ToLower().Trim())) sbSql.AppendFormat("FirstName = '{0}', ", update.FirstName);
                if (request.MiddleName != null && !originalStaff.MiddleName.ToLower().Trim().Equals(request.MiddleName.ToLower().Trim())) sbSql.AppendFormat("MiddleName = '{0}', ", request.MiddleName);
                if (!originalStaff.LastName.ToLower().Trim().Equals(update.LastName.ToLower().Trim())) sbSql.AppendFormat("LastName = '{0}', ", update.LastName);
                if (!originalStaff.Address.ToLower().Trim().Equals(update.Address.ToLower().Trim())) sbSql.AppendFormat("Address = '{0}', ", update.Address);
                if (originalStaff.Address2 == null && originalStaff.Address2 != update.Address2) sbSql.AppendFormat("Address2 = '{0}', ", update.Address2);
                if (originalStaff.Address2 != null && !originalStaff.Address2.Equals(update.Address2)) sbSql.AppendFormat("Address2 = '{0}', ", update.Address2);
                if (!originalStaff.City.ToLower().Trim().Equals(update.City.ToLower().Trim())) sbSql.AppendFormat("City = '{0}', ", update.City);
                if (!originalStaff.State.ToLower().Trim().Equals(update.State.ToLower().Trim())) sbSql.AppendFormat("State = '{0}', ", update.State);
                if (!originalStaff.PostalCode.ToLower().Trim().Equals(update.PostalCode.ToLower().Trim())) sbSql.AppendFormat("PostalCode = '{0}', ", update.PostalCode);
                if (!originalStaff.Country.ToLower().Trim().Equals(update.Country.ToLower().Trim())) sbSql.AppendFormat("Country = '{0}', ", update.Country);
                if (!originalStaff.Gender.ToLower().Trim().Equals(update.Gender.ToLower().Trim())) sbSql.AppendFormat("Gender = '{0}', ", update.Gender);
                //if (!originalStaff.Role.Equals(update.Role)) sbSql.AppendFormat("Role = '{0}', ", update.Role);
                if (!originalStaff.EmailAddress.ToLower().Trim().Equals(update.EmailAddress.ToLower().Trim())) sbSql.AppendFormat("EmailAddress = '{0}', ", update.EmailAddress);
                if (!originalStaff.PhoneNumber.ToLower().Trim().Equals(update.PhoneNumber.ToLower().Trim())) sbSql.AppendFormat("PhoneNumber = '{0}', ", update.PhoneNumber);
                if (originalStaff.Note == null && originalStaff.Note != update.Note) sbSql.AppendFormat("Note = '{0}', ", update.Note);
                if (originalStaff.Note != null && !originalStaff.Note.Equals(update.Note)) sbSql.AppendFormat("Note = '{0}', ", update.Note);
                if (originalStaff.StaffFileName == null && originalStaff.StaffFileName != update.StaffFileName) sbSql.AppendFormat("StaffFileName = '{0}', ", update.StaffFileName);

                if (request.StaffImage != null && originalStaff.StaffImage != null)
                {
                    if (!request.StaffImage.Equals(originalStaff.StaffImage))
                    {
                        sbSql.AppendFormat("StaffImage = '{0}', ", request.StaffImage);
                    }
                }
                else if (request.StaffImage != null && originalStaff.StaffImage == null)
                {
                    sbSql.AppendFormat("StaffImage = '{0}', ", request.StaffImage);
                }

                if (!originalStaff.RememberMe.Equals(update.RememberMe)) sbSql.AppendFormat("RememberMe = {0}, ", update.RememberMe);

                if (update.UnlockUser)
                {
                    sbSql.AppendFormat("IsLockedOut = {0}, ", 0);
                    sbSql.AppendFormat("LoginAttempts = {0}, ", 0);
                }

                if (!originalStaff.LoginAttempts.Equals(update.LoginAttempts)) sbSql.AppendFormat("LoginAttempts = {0}, ", update.LoginAttempts);
                if (!originalStaff.IsActive.Equals(update.IsActive)) sbSql.AppendFormat("IsActive = {0}, ", update.IsActive);
                if (!originalStaff.EmailConfirmed.Equals(update.EmailConfirmed)) sbSql.AppendFormat("EmailConfirmed = {0}, ", update.EmailConfirmed);

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
                throw;
            }

            return _repositoryResponse;
        }

        public void CustomMyProfileUpdate(MyProfileRequest request)
        {
            try
            {
                StringBuilder sbSql = new StringBuilder("UPDATE Staff\n");
                sbSql.Append("SET ");
                var originalStaff = GetStaffWithDetails(x => x.EmailAddress == request.EmailAddress && x.PropertyId == request.PropertyId, request.PropertyId, request.EmailAddress, WithDetails.Yes).FirstOrDefault();

                if (!originalStaff.FirstName.ToLower().Trim().Equals(request.FirstName.ToLower().Trim())) sbSql.AppendFormat("FirstName = '{0}', ", request.FirstName);
                
                if (String.IsNullOrEmpty(request.MiddleName) && !String.IsNullOrEmpty(originalStaff.MiddleName))
                {
                    sbSql.AppendFormat("MiddleName = '{0}', ", DBNull.Value);
                }

                if (!String.IsNullOrEmpty(request.MiddleName) && String.IsNullOrEmpty(originalStaff.MiddleName))
                {
                    sbSql.AppendFormat("MiddleName = '{0}', ", request.MiddleName);
                }

                if (!String.IsNullOrEmpty(request.MiddleName) && !String.IsNullOrEmpty(originalStaff.MiddleName) && !originalStaff.MiddleName.ToLower().Trim().Equals(request.MiddleName.ToLower().Trim()))
                {
                    sbSql.AppendFormat("MiddleName = '{0}', ", request.MiddleName);
                }
                
                if (!originalStaff.LastName.ToLower().Trim().Equals(request.LastName.ToLower().Trim())) sbSql.AppendFormat("LastName = '{0}', ", request.LastName);
                if (!originalStaff.Address.ToLower().Trim().Equals(request.Address.ToLower().Trim())) sbSql.AppendFormat("Address = '{0}', ", request.Address);

                if (String.IsNullOrEmpty(request.Address2) && !String.IsNullOrEmpty(originalStaff.Address2))
                {
                    sbSql.AppendFormat("Address2 = '{0}', ", DBNull.Value);
                }

                if (!String.IsNullOrEmpty(request.Address2) && String.IsNullOrEmpty(originalStaff.Address2))
                {
                    sbSql.AppendFormat("Address2 = '{0}', ", request.Address2);
                }

                if (!String.IsNullOrEmpty(request.Address2) && !String.IsNullOrEmpty(originalStaff.Address2) && !originalStaff.Address2.ToLower().Trim().Equals(request.Address2.ToLower().Trim()))
                {
                    sbSql.AppendFormat("Address2 = '{0}', ", request.Address2);
                }

                if (!originalStaff.City.ToLower().Trim().Equals(request.City.ToLower().Trim())) sbSql.AppendFormat("City = '{0}', ", request.City);

                if (String.IsNullOrEmpty(request.State) && !String.IsNullOrEmpty(originalStaff.State))
                {
                    sbSql.AppendFormat("State = '{0}', ", DBNull.Value);
                }

                if (!String.IsNullOrEmpty(request.State) && String.IsNullOrEmpty(originalStaff.State))
                {
                    sbSql.AppendFormat("State = '{0}', ", request.State);
                }

                if (!String.IsNullOrEmpty(request.State) && !String.IsNullOrEmpty(originalStaff.State) && !originalStaff.State.ToLower().Trim().Equals(request.State.ToLower().Trim()))
                {
                    sbSql.AppendFormat("State = '{0}', ", request.State);
                }

                if (!originalStaff.PostalCode.ToLower().Trim().Equals(request.PostalCode.ToLower().Trim())) sbSql.AppendFormat("PostalCode = '{0}', ", request.PostalCode);
                if (!originalStaff.Country.ToLower().Trim().Equals(request.Country.ToLower().Trim())) sbSql.AppendFormat("Country = '{0}', ", request.Country);
                if (!originalStaff.EmailAddress.ToLower().Trim().Equals(request.EmailAddress.ToLower().Trim())) sbSql.AppendFormat("EmailAddress = '{0}', ", request.EmailAddress);
                if (!originalStaff.PhoneNumber.ToLower().Trim().Equals(request.PhoneNumber.ToLower().Trim())) sbSql.AppendFormat("PhoneNumber = '{0}', ", request.PhoneNumber);
                if (!originalStaff.Gender.ToLower().Trim().Equals(request.Gender.ToLower().Trim())) sbSql.AppendFormat("Gender = '{0}', ", request.Gender);

                sbSql.AppendFormat("UpdatedBy = '{0}', ", request.UpdatedBy);
                sbSql.AppendFormat("UpdatedDate = '{0}', ", request.UpdatedDate);
                SqlParameter imgParam = null;
                SqlParameter fileNameParam = null;

                if (!String.IsNullOrEmpty(request.StaffFileName) && !String.IsNullOrEmpty(originalStaff.StaffFileName))
                {
                    if (!request.StaffFileName.Equals(originalStaff.StaffFileName))
                    {
                        sbSql.Append("StaffFileName = @FileName, ");
                        fileNameParam = new SqlParameter("FileName", SqlDbType.VarChar, 150);
                        fileNameParam.Value = request.StaffFileName;

                        sbSql.Append("StaffImage = @Img  ");
                        imgParam = new SqlParameter("Img", SqlDbType.Image);
                        imgParam.Value = request.StaffImage;
                    }
                }
                else if (!String.IsNullOrEmpty(request.StaffFileName) && String.IsNullOrEmpty(originalStaff.StaffFileName))
                {
                    sbSql.Append("StaffFileName = @FileName, ");
                    fileNameParam = new SqlParameter("FileName", SqlDbType.VarChar, 150);
                    fileNameParam.Value = request.StaffFileName;

                    sbSql.Append("StaffImage = @Img  ");
                    imgParam = new SqlParameter("Img", SqlDbType.Image);
                    imgParam.Value = request.StaffImage;
                }

                sbSql = new StringBuilder(sbSql.ToString().Substring(0, sbSql.ToString().Length - 2));
                sbSql.AppendFormat(" WHERE EmailAddress = '{0}' AND PropertyId = {1}", request.EmailAddress, request.PropertyId);
                _context.Database.ExecuteSqlRaw(sbSql.ToString(), imgParam, fileNameParam);

                if (request.CredentialIds == null)
                {
                    request.CredentialIds = new int[0];
                }

                var origintalCredentialIds = originalStaff.Credentials.Select(x => x.CredentialId).ToArray();
                Array.Sort(origintalCredentialIds);
                Array.Sort(request.CredentialIds);

                if (origintalCredentialIds.Length == 0 && request.CredentialIds.Length > 0)
                {
                    sbSql = new StringBuilder();
                    foreach (int credId in request.CredentialIds)
                    {
                        sbSql.AppendFormat("INSERT INTO StaffCredentials (StaffId, CredentialId, PropertyId) VALUES({0}, {1}, {2})", originalStaff.StaffId, credId, originalStaff.PropertyId);
                    }

                    _context.Database.ExecuteSqlRaw(sbSql.ToString());
                }

                if (origintalCredentialIds.Length > 0 && request.CredentialIds.Length == 0)
                {
                    sbSql = new StringBuilder();
                    sbSql.AppendFormat("DELETE FROM StaffCredentials WHERE PropertyId={0} AND StaffId={1}", originalStaff.PropertyId, originalStaff.StaffId);
                    _context.Database.ExecuteSqlRaw(sbSql.ToString());
                }

                if ((origintalCredentialIds != null && origintalCredentialIds.Length > 0) && (request.CredentialIds != null && request.CredentialIds.Length > 0))
                {
                    bool equal = origintalCredentialIds.SequenceEqual(request.CredentialIds);
                    if (!equal)
                    {
                        var clientDelta = request.CredentialIds.Except(request.CredentialIds.Where(o => origintalCredentialIds.Select(s => s).ToList().Contains(o))).ToList();
                        sbSql = new StringBuilder();
                        foreach (int credId in clientDelta)
                        {
                            sbSql.AppendFormat("INSERT INTO StaffCredentials (StaffId, CredentialId, PropertyId) VALUES({0}, {1}, {2})", originalStaff.StaffId, credId, originalStaff.PropertyId);
                        }
                        
                        if (sbSql.Length > 0)
                        {
                            _context.Database.ExecuteSqlRaw(sbSql.ToString());
                        }

                        var serverDelta = origintalCredentialIds.Except(origintalCredentialIds.Where(o => request.CredentialIds.Select(s => s).ToList().Contains(o))).ToList();
                        sbSql = new StringBuilder();
                        foreach (int credId in serverDelta)
                        {
                            sbSql.AppendFormat("DELETE StaffCredentials WHERE PropertyId={0} AND StaffId={1} AND CredentialId={2}", request.PropertyId, originalStaff.StaffId, credId);
                        }

                        if (sbSql.Length > 0)
                        {
                            _context.Database.ExecuteSqlRaw(sbSql.ToString());
                        }
                    }
                }

                Staff updatedStaff = _context.Staff.First(x => x.EmailAddress == request.EmailAddress && x.PropertyId == request.PropertyId);
                _myProfileRepositoryResponse.Entity = _mapper.Map<MyProfileRequest>(updatedStaff);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CustomStaffUpdate(Staff request, int[] credentialIds)
        {
            try
            {
                StringBuilder sbSql = new StringBuilder("UPDATE Staff\n");
                sbSql.Append("SET ");
             
                if (request.NewRegistration)
                {
                    if (request.NewRegistrationApproved)
                    {
                        sbSql.AppendFormat("NewRegistration = 0, NewRegistrationApproved = 1, IsActive = 1 WHERE PropertyId={0} AND StaffId={1}", request.PropertyId, request.StaffId );
                        _context.Database.ExecuteSqlRaw(sbSql.ToString());
                    }
                    else
                    {
                        sbSql.AppendFormat("NewRegistration = 0, NewRegistrationApproved = 0, IsActive = 0 WHERE PropertyId={0} AND StaffId={1}", request.PropertyId, request.StaffId);
                        _context.Database.ExecuteSqlRaw(sbSql.ToString());
                    }
                }
                else
                {
                    var originalStaff = GetStaffWithDetails(x => x.EmailAddress == request.EmailAddress && x.PropertyId == request.PropertyId, request.PropertyId, request.EmailAddress, WithDetails.Yes).FirstOrDefault();

                    if (!originalStaff.FirstName.ToLower().Trim().Equals(request.FirstName.ToLower().Trim())) sbSql.AppendFormat("FirstName = '{0}', ", request.FirstName);

                    if (String.IsNullOrEmpty(request.MiddleName) && !String.IsNullOrEmpty(originalStaff.MiddleName))
                    {
                        sbSql.AppendFormat("MiddleName = '{0}', ", DBNull.Value);
                    }

                    if (!String.IsNullOrEmpty(request.MiddleName) && String.IsNullOrEmpty(originalStaff.MiddleName))
                    {
                        sbSql.AppendFormat("MiddleName = '{0}', ", request.MiddleName);
                    }

                    if (!String.IsNullOrEmpty(request.MiddleName) && !String.IsNullOrEmpty(originalStaff.MiddleName) && !originalStaff.MiddleName.ToLower().Trim().Equals(request.MiddleName.ToLower().Trim()))
                    {
                        sbSql.AppendFormat("MiddleName = '{0}', ", request.MiddleName);
                    }

                    if (!originalStaff.LastName.ToLower().Trim().Equals(request.LastName.ToLower().Trim())) sbSql.AppendFormat("LastName = '{0}', ", request.LastName);
                    if (!originalStaff.Address.ToLower().Trim().Equals(request.Address.ToLower().Trim())) sbSql.AppendFormat("Address = '{0}', ", request.Address);

                    if (String.IsNullOrEmpty(request.Address2) && !String.IsNullOrEmpty(originalStaff.Address2))
                    {
                        sbSql.AppendFormat("Address2 = '{0}', ", DBNull.Value);
                    }

                    if (!String.IsNullOrEmpty(request.Address2) && String.IsNullOrEmpty(originalStaff.Address2))
                    {
                        sbSql.AppendFormat("Address2 = '{0}', ", request.Address2);
                    }

                    if (!String.IsNullOrEmpty(request.Address2) && !String.IsNullOrEmpty(originalStaff.Address2) && !originalStaff.Address2.ToLower().Trim().Equals(request.Address2.ToLower().Trim()))
                    {
                        sbSql.AppendFormat("Address2 = '{0}', ", request.Address2);
                    }

                    if (!originalStaff.City.ToLower().Trim().Equals(request.City.ToLower().Trim())) sbSql.AppendFormat("City = '{0}', ", request.City);

                    if (String.IsNullOrEmpty(request.State) && !String.IsNullOrEmpty(originalStaff.State))
                    {
                        sbSql.AppendFormat("State = '{0}', ", DBNull.Value);
                    }

                    if (!String.IsNullOrEmpty(request.State) && String.IsNullOrEmpty(originalStaff.State))
                    {
                        sbSql.AppendFormat("State = '{0}', ", request.State);
                    }

                    if (!String.IsNullOrEmpty(request.State) && !String.IsNullOrEmpty(originalStaff.State) && !originalStaff.State.ToLower().Trim().Equals(request.State.ToLower().Trim()))
                    {
                        sbSql.AppendFormat("State = '{0}', ", request.State);
                    }

                    if (!originalStaff.PostalCode.ToLower().Trim().Equals(request.PostalCode.ToLower().Trim())) sbSql.AppendFormat("PostalCode = '{0}', ", request.PostalCode);
                    if (!originalStaff.Country.ToLower().Trim().Equals(request.Country.ToLower().Trim())) sbSql.AppendFormat("Country = '{0}', ", request.Country);
                    if (!originalStaff.EmailAddress.ToLower().Trim().Equals(request.EmailAddress.ToLower().Trim())) sbSql.AppendFormat("EmailAddress = '{0}', ", request.EmailAddress);
                    if (!originalStaff.PhoneNumber.ToLower().Trim().Equals(request.PhoneNumber.ToLower().Trim())) sbSql.AppendFormat("PhoneNumber = '{0}', ", request.PhoneNumber);
                    if (!originalStaff.Gender.ToLower().Trim().Equals(request.Gender.ToLower().Trim())) sbSql.AppendFormat("Gender = '{0}', ", request.Gender);
                    if (!originalStaff.CanSendMessages.Equals(request.CanSendMessages)) sbSql.AppendFormat("CanSendMessages = {0}, ", request.CanSendMessages == true ? 1 : 0);
                    if (!originalStaff.CanViewDocuments.Equals(request.CanViewDocuments)) sbSql.AppendFormat("CanViewDocuments = {0}, ", request.CanViewDocuments == true ? 1 : 0);
                    //if (!originalStaff.IsActive.Equals(request.IsActive)) sbSql.AppendFormat("IsActive = {0}, ", request.IsActive == true ? 1 : 0);
                    //if (!originalStaff.IsLockedOut.Equals(request.IsLockedOut)) sbSql.AppendFormat("IsLockedOut = {0}, ", request.IsLockedOut == true ? 1 : 0);
                    //if (!originalStaff.LoginAttempts.Equals(request.IsLockedOut)) sbSql.AppendFormat("IsLockedOut = {0}, ", request.IsLockedOut == true ? 1 : 0);

                    if (String.IsNullOrEmpty(request.Note) && !String.IsNullOrEmpty(originalStaff.Note))
                    {
                        sbSql.AppendFormat("Note = '{0}', ", DBNull.Value);
                    }

                    if (!String.IsNullOrEmpty(request.Note) && String.IsNullOrEmpty(originalStaff.Note))
                    {
                        sbSql.AppendFormat("Note = '{0}', ", request.Note);
                    }

                    if (!String.IsNullOrEmpty(request.Note) && !String.IsNullOrEmpty(originalStaff.Note) && !originalStaff.Note.ToLower().Trim().Equals(request.Note.ToLower().Trim()))
                    {
                        sbSql.AppendFormat("Note = '{0}', ", request.Note);
                    }

                    sbSql.AppendFormat("UpdatedBy = '{0}', ", request.UpdatedBy);
                    sbSql.AppendFormat("UpdatedDate = '{0}', ", request.UpdatedDate);
                    SqlParameter imgParam = null;
                    SqlParameter fileNameParam = null;

                    if (!String.IsNullOrEmpty(request.StaffFileName) && !String.IsNullOrEmpty(originalStaff.StaffFileName))
                    {
                        if (!request.StaffFileName.Equals(originalStaff.StaffFileName))
                        {
                            sbSql.Append("StaffFileName = @FileName, ");
                            fileNameParam = new SqlParameter("FileName", SqlDbType.VarChar, 150);
                            fileNameParam.Value = request.StaffFileName;

                            sbSql.Append("StaffImage = @Img  ");
                            imgParam = new SqlParameter("Img", SqlDbType.Image);
                            imgParam.Value = request.StaffImage;
                        }
                    }
                    else if (!String.IsNullOrEmpty(request.StaffFileName) && String.IsNullOrEmpty(originalStaff.StaffFileName))
                    {
                        sbSql.Append("StaffFileName = @FileName, ");
                        fileNameParam = new SqlParameter("FileName", SqlDbType.VarChar, 150);
                        fileNameParam.Value = request.StaffFileName;

                        sbSql.Append("StaffImage = @Img  ");
                        imgParam = new SqlParameter("Img", SqlDbType.Image);
                        imgParam.Value = request.StaffImage;
                    }

                    sbSql = new StringBuilder(sbSql.ToString().Substring(0, sbSql.ToString().Length - 2));
                    sbSql.AppendFormat(" WHERE EmailAddress = '{0}' AND PropertyId = {1}", request.EmailAddress, request.PropertyId);

                    _context.Database.ExecuteSqlRaw(sbSql.ToString(), imgParam, fileNameParam);

                    if (credentialIds == null)
                    {
                        credentialIds = new int[0];
                    }

                    var origintalCredentialIds = originalStaff.Credentials.Select(x => x.CredentialId).ToArray();
                    Array.Sort(origintalCredentialIds);
                    Array.Sort(credentialIds);

                    if (origintalCredentialIds.Length == 0 && credentialIds.Length > 0)
                    {
                        sbSql = new StringBuilder();
                        foreach (int credId in credentialIds)
                        {
                            sbSql.AppendFormat("INSERT INTO StaffCredentials (StaffId, CredentialId, PropertyId) VALUES({0}, {1}, {2})", originalStaff.StaffId, credId, originalStaff.PropertyId);
                        }

                        _context.Database.ExecuteSqlRaw(sbSql.ToString());
                    }

                    if (origintalCredentialIds.Length > 0 && credentialIds.Length == 0)
                    {
                        sbSql = new StringBuilder();
                        sbSql.AppendFormat("DELETE FROM StaffCredentials WHERE PropertyId={0} AND StaffId={1}", originalStaff.PropertyId, originalStaff.StaffId);
                        _context.Database.ExecuteSqlRaw(sbSql.ToString());
                    }

                    if ((origintalCredentialIds != null && origintalCredentialIds.Length > 0) && (credentialIds != null && credentialIds.Length > 0))
                    {
                        bool equal = origintalCredentialIds.SequenceEqual(credentialIds);
                        if (!equal)
                        {
                            var clientDelta = credentialIds.Except(credentialIds.Where(o => origintalCredentialIds.Select(s => s).ToList().Contains(o))).ToList();
                            sbSql = new StringBuilder();
                            foreach (int credId in clientDelta)
                            {
                                sbSql.AppendFormat("INSERT INTO StaffCredentials (StaffId, CredentialId, PropertyId) VALUES({0}, {1}, {2})", originalStaff.StaffId, credId, originalStaff.PropertyId);
                            }

                            if (sbSql.Length > 0)
                            {
                                _context.Database.ExecuteSqlRaw(sbSql.ToString());
                            }

                            var serverDelta = origintalCredentialIds.Except(origintalCredentialIds.Where(o => credentialIds.Select(s => s).ToList().Contains(o))).ToList();
                            sbSql = new StringBuilder();
                            foreach (int credId in serverDelta)
                            {
                                sbSql.AppendFormat("DELETE StaffCredentials WHERE PropertyId={0} AND StaffId={1} AND CredentialId={2}", request.PropertyId, originalStaff.StaffId, credId);
                            }

                            if (sbSql.Length > 0)
                            {
                                _context.Database.ExecuteSqlRaw(sbSql.ToString());
                            }
                        }
                    }
                }

                Staff updatedStaff = _context.Staff.First(x => x.StaffId == request.StaffId && x.PropertyId == request.PropertyId);
                _myProfileRepositoryResponse.Entity = _mapper.Map<MyProfileRequest>(updatedStaff);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void RecordLoginAttempts(string userId, int propertyId)
        {
            try
            {
                Staff staff = _context.Set<Staff>().SingleOrDefault(x => x.EmailAddress == userId && x.PropertyId == propertyId);
                staff.LoginAttempts++;
                _context.Set<Staff>().Attach(staff);
                _context.Entry(staff).State = EntityState.Modified;
                _context.Update(staff);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ResetLoginAttempts(string userId, int propertyId)
        {
            try
            {
                Staff staff = _context.Set<Staff>().SingleOrDefault(x => x.EmailAddress == userId && x.PropertyId == propertyId);
                staff.LoginAttempts = 0;
                _context.Set<Staff>().Attach(staff);
                _context.Entry(staff).State = EntityState.Modified;
                _context.Update(staff);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<Staff> GetAllStaff(int propertyId, string userId)
        {
            var staff = FindAll(propertyId, userId).OrderBy(x => x.FirstName).AsNoTracking();
            return staff.Where(x => x.PropertyId == propertyId);
        }

        public IQueryable<Staff> GetStaffByMatch(Expression<Func<Staff, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<Staff> GetStaffWithDetails(Expression<Func<Staff, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.Yes:
                    return FindByCondition(match, propertyId, userId).Include(x=>x.Credentials).Include(x=>x.RefreshTokens).Include(x=>x.Roles).AsNoTracking();
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public Staff CreateStaff(Staff staff, int propertyId, string userId)
        {
            return Create(staff, propertyId, userId);
        }

        public bool UpdateStaff(Staff staff, int propertyId, string userId)
        {
            return Update(staff, propertyId, userId);
        }

        public bool DeleteStaff(Staff staff, int propertyId, string userId)
        {
            return Delete(staff, propertyId, userId);
        }
    }
}
