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

namespace TempleVolunteerAPI.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplicationDBContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private RepositoryResponse<T> _repositoryResponse;

        public RepositoryBase(ApplicationDBContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork(context);
            _repositoryResponse = new RepositoryResponse<T>();
        }

        public async Task<RepositoryResponse<T>> GetAllAsync()
        {
            try
            {
                _repositoryResponse.Entities = await _context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> GetByIdAsync(int id)
        {
            try
            {
                _repositoryResponse.Entity = await _context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> FindAsync(Expression<Func<T, bool>> match)
        {
            try
            {
                _repositoryResponse.Entity = await _context.Set<T>().SingleOrDefaultAsync(match);
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            try
            {
                _repositoryResponse.Entities = await _context.Set<T>().Where(match).ToListAsync();
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> AddAsync(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                await _unitOfWork.CommitAsync();
                _repositoryResponse.Entity = entity;
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> UpdateAsync(T entity)
        {
            try
            {
                _context.Set<T>().Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                await _unitOfWork.CommitAsync();
                _repositoryResponse.Entity = entity;
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> DeleteAsync(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                await _unitOfWork.CommitAsync();
                _repositoryResponse.Entity = entity;
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> Filter(
                Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", int? page = null, int? pageSize = null)
        {
            try
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

                _repositoryResponse.Entities = query.ToList();
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> ExistAsync(Expression<Func<T, bool>> match)
        {
            try
            {
                _repositoryResponse.Result = await _context.Set<T>().Where(match).FirstOrDefaultAsync() == null ? false : true;
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> CountAync()
        {
            try
            {
                _repositoryResponse.Count = await _context.Set<T>().CountAsync();
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> FindByAsync(Expression<Func<T, bool>> match)
        {
            try
            {
                _repositoryResponse.Entities = await _context.Set<T>().Where(match).ToListAsync();
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> LogError(T entity)
        {
            try
            {

                _context.Set<T>().Add(entity);
                await _unitOfWork.CommitAsync();
                _repositoryResponse.Entity = entity;
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> RecordLoginAttempts(string userId, int propertyId)
        {
            try
            {
                Staff staff = await _context.Set<Staff>().SingleOrDefaultAsync(x => x.EmailAddress == userId && x.PropertyId == propertyId);
                
                if (staff == null)
                {
                    _repositoryResponse.Error = new Exception("RecordLoginAttempts: User not found.");
                    return _repositoryResponse;
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

                _repositoryResponse.Count = staff.LoginAttempts;
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public async Task<RepositoryResponse<T>> ResetLoginAttempts(string userId, int propertyId)
        {
            try
            {
                Staff staff = await _context.Set<Staff>().SingleOrDefaultAsync(x => x.EmailAddress == userId && x.PropertyId == propertyId);
                staff.LoginAttempts = 0;
                staff.IsLockedOut = false;
                _context.Set<Staff>().Attach(staff);
                _context.Entry(staff).State = EntityState.Modified;
                _context.Update(staff);
                await _unitOfWork.CommitAsync();

                _repositoryResponse.Result = true;
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse;
        }

        public Task<Staff> CustomUpdateAsync(Staff request)
        {
            throw new NotImplementedException();
        }

        public Task<RepositoryResponse<T>> LogError(LogErrorParms parms)
        {
            throw new NotImplementedException();
        }
    }
}
