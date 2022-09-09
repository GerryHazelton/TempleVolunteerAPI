using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using System.Linq.Expressions;
using System.Text;

namespace TempleVolunteerAPI.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplicationDBContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public RepositoryBase(ApplicationDBContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork(context);
        }

        public async Task<IList<T>> GetAllAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            try
            {
                return await _context.Set<T>().SingleOrDefaultAsync(match);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            try
            {
                return await _context.Set<T>().Where(match).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task<bool> AddAsync(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                _context.Set<T>().Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                await _unitOfWork.CommitAsync();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                await _unitOfWork.CommitAsync();
            }
            catch
            {
                return false;
            }

            return true;
        }


        public IEnumerable<T> Filter(
            Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
            string includeProperties = "", 
            int? page = null,
            int? pageSize = null)
            {
                IQueryable<T> query = _context.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (page != null && pageSize != null)
            {
                query = query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);
            }

            return query.ToList();
        }

        public async Task<bool> ExistAsync(Expression<Func<T, bool>> match)
        {
            try
            {
                return await _context.Set<T>().Where(match).FirstOrDefaultAsync() == null ? false : true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> CountAync()
        {
            try
            {
                return await _context.Set<T>().CountAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<T>> FindByAsync(Expression<Func<T, bool>> match)
        {
            try
            {
                return await _context.Set<T>().Where(match).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> CustomSqlProcessAsync(T instance, string userId)
        {
            try
            {
                if (instance is Staff)
                {
                    Staff update = (Staff)(object)instance;
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
                        return true;
                    }
                    
                    sbSql = new StringBuilder(sbSql.ToString().Substring(0, sbSql.ToString().Length - 2));
                    sbSql.AppendFormat(" WHERE StaffId = {0}", update.StaffId);
                    await _context.Database.ExecuteSqlRawAsync(sbSql.ToString());
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public void LogError(LogErrorParms parms)
        {
            throw new NotImplementedException();
        }

        public async Task<int> RecordLoginAttempts(string userId)
        {
            try
            {
                Staff staff = await _context.Set<Staff>().SingleOrDefaultAsync(x => x.EmailAddress == userId);
                
                if (staff == null)
                {
                    return 0;
                }

                staff.LoginAttempts = staff.LoginAttempts + 1;

                if (staff.LoginAttempts > 3)
                {
                    staff.IsLockedOut = true;
                }

                _context.Set<Staff>().Attach(staff);
                _context.Entry(staff).State = EntityState.Modified;
                _context.Update(staff);
                await _unitOfWork.CommitAsync();
                return staff.LoginAttempts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ResetLoginAttempts(string userId)
        {
            try
            {
                Staff staff = await _context.Set<Staff>().SingleOrDefaultAsync(x => x.EmailAddress == userId);
                staff.LoginAttempts = 0;
                staff.IsLockedOut = false;
                _context.Set<Staff>().Attach(staff);
                _context.Entry(staff).State = EntityState.Modified;
                _context.Update(staff);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}
