using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using System.Linq.Expressions;
using System.Text;
using TempleVolunteerAPI.Domain.DTO;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace TempleVolunteerAPI.Repository
{
    public class RepositoryManyToManyBase<T> : IRepositoryManyToManyBase<T> where T : class
    {
        private readonly ApplicationDBContext _context;
        public RepositoryManyToManyBase(ApplicationDBContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll(int propertyId, string userId)
        {
            try
            {
                return this._context.Set<T>().AsNoTracking();
            }
            catch (Exception ex)
            {
                ErrorLogEntry(new ErrorLog
                {
                    FunctionName = "Repository: AddAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = userId,
                    CreatedDate = DateTime.UtcNow
                });

                return null;
            }
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> match, int propertyId, string userId)
        {
            try
            {
                var result = this._context.Set<T>().Where(match).AsNoTracking();

                return result;
            }
            catch (Exception ex)
            {
                ErrorLogEntry(new ErrorLog
                {
                    FunctionName = "Repository: AddAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = userId,
                    CreatedDate = DateTime.UtcNow
                });

                return null;
            }
        }

        public bool Create(T entity, int propertyId, string userId)
        {
            try
            {
                this._context.Set<T>().Add(entity);
                this._context.SaveChanges();
                
                return true;
            }
            catch (Exception ex)
            {
                ErrorLogEntry(new ErrorLog
                {
                    FunctionName = "Repository: AddAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = userId,
                    CreatedDate = DateTime.UtcNow
                });

                return false;
            }
        }

        public bool Update(T entity, int propertyId, string userId)
        {
            try
            {
                this._context.Set<T>().Update(entity);
                _context.Entry(entity).State = EntityState.Modified;
                this._context.SaveChanges();
                
                return true;
            }
            catch (Exception ex)
            {
                ErrorLogEntry(new ErrorLog
                {
                    FunctionName = "Repository: AddAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = userId,
                    CreatedDate = DateTime.UtcNow
                });

                return false;
            }
        }

        public bool Delete(T entity, int propertyId, string userId)
        {
            try
            {
                this._context.Set<T>().Remove(entity);
                this._context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                ErrorLogEntry(new ErrorLog
                {
                    FunctionName = "Repository: AddAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = userId,
                    CreatedDate = DateTime.UtcNow
                });

                return false;
            }
        }

        public void ErrorLogEntry(ErrorLog error)
        {
            _context.Set<ErrorLog>().Add(error);
        }
    }
}
