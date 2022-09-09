using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Domain;
using System.Text;

namespace TempleVolunteerAPI.Repository
{
    public class StaffRepository : RepositoryBase<Staff>, IStaffRepository
    {
        private ApplicationDBContext _context;
        public StaffRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<Staff> CustomUpdateAsync(Staff updated)
        {
            StringBuilder sbSql = new StringBuilder("UPDATE Staff\n");
            sbSql.Append("SET ");
            Staff updateStaff = await _context.Staff.FindAsync(updated.StaffId);

            if (!updateStaff.FirstName.ToLower().Trim().Equals(updated.FirstName.ToLower().Trim())) sbSql.AppendFormat("FirstName = '{0}', ", updated.FirstName);
            if (!updateStaff.LastName.ToLower().Trim().Equals(updated.LastName.ToLower().Trim())) sbSql.AppendFormat("LastName = '{0}', ", updated.LastName);
            if (!updateStaff.Address.ToLower().Trim().Equals(updated.Address.ToLower().Trim())) sbSql.AppendFormat("AddressName = '{0}', ", updated.Address);
            if (!updateStaff.Address2.ToLower().Trim().Equals(updated.Address2.ToLower().Trim())) sbSql.AppendFormat("Address2 = '{0}', ", updated.Address2);
            if (!updateStaff.City.ToLower().Trim().Equals(updated.City.ToLower().Trim())) sbSql.AppendFormat("City = '{0}', ", updated.City);
            if (!updateStaff.State.ToLower().Trim().Equals(updated.State.ToLower().Trim())) sbSql.AppendFormat("State = '{0}', ", updated.State);
            if (!updateStaff.PostalCode.ToLower().Trim().Equals(updated.PostalCode.ToLower().Trim())) sbSql.AppendFormat("PostalCode = '{0}', ", updated.PostalCode);
            if (!updateStaff.Country.ToLower().Trim().Equals(updated.Country.ToLower().Trim())) sbSql.AppendFormat("Country = '{0}', ", updated.Country);
            //if (!updateStaff.Role.Equals(updated.Role)) sbSql.AppendFormat("Role = {0}, ", updated.Role);
            if (!updateStaff.EmailAddress.ToLower().Trim().Equals(updated.EmailAddress.ToLower().Trim())) sbSql.AppendFormat("EmailAddress = '{0}', ", updated.EmailAddress);
            if (!updateStaff.PhoneNumber.ToLower().Trim().Equals(updated.PhoneNumber.ToLower().Trim())) sbSql.AppendFormat("PhoneNumber = '{0}', ", updated.PhoneNumber);
            if (!updateStaff.FirstAid.Equals(updated.FirstAid)) sbSql.AppendFormat("FirstAid = {0}, ", updated.FirstAid);
            if (!updateStaff.CPR.Equals(updated.CPR)) sbSql.AppendFormat("CPR = {0}, ", updated.CPR);
            if (!updateStaff.Kriyaban.Equals(updated.Kriyaban)) sbSql.AppendFormat("Kriyaban = {0}, ", updated.Kriyaban);
            if (!updateStaff.LessonStudent.Equals(updated.LessonStudent)) sbSql.AppendFormat("LessonStudent = {0}, ", updated.LessonStudent);
            if (!updateStaff.Note.ToLower().Trim().Equals(updated.Note.ToLower().Trim())) sbSql.AppendFormat("Note = '{0}', ", updated.Note);
            if (!updateStaff.StaffFileName.ToLower().Trim().Equals(updated.StaffFileName.ToLower().Trim())) sbSql.AppendFormat("StaffFileName = '{0}', ", updated.StaffFileName);
            if (!updateStaff.StaffImage.Equals(updated.StaffImage)) sbSql.AppendFormat("StaffImage = '{0}', ", updated.StaffImage);
            if (!updateStaff.RememberMe.Equals(updated.RememberMe)) sbSql.AppendFormat("RememberMe = {0}, ", updated.RememberMe);
            if (!updateStaff.IsLockedOut.Equals(updated.IsLockedOut)) sbSql.AppendFormat("IsLockedOut = {0}, ", updated.IsLockedOut);
            if (!updateStaff.LoginAttempts.Equals(updated.LoginAttempts)) sbSql.AppendFormat("LoginAttempts = {0}, ", updated.LoginAttempts);
            sbSql = new StringBuilder(sbSql.ToString().Substring(0, sbSql.ToString().Length - 1));
            sbSql.AppendFormat("\nWHERE StaffId = {0}", updated.StaffId);
            await _context.Database.ExecuteSqlRawAsync(sbSql.ToString());

            return await _context.Staff.FindAsync(updated.StaffId);
        }

        public async Task<int> RecordLoginAttempts(string userId)
        {
            try
            {
                Staff staff = await _context.Set<Staff>().SingleOrDefaultAsync(x => x.EmailAddress == userId);
                staff.LoginAttempts++;
                _context.Set<Staff>().Attach(staff);
                _context.Entry(staff).State = EntityState.Modified;
                _context.Update(staff);
                
                return staff.LoginAttempts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
