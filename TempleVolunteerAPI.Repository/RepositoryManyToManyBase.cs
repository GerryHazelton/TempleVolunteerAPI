using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Domain;
using System.Text;

namespace TempleVolunteerAPI.Repository
{
    public class RepositoryManyToManyBase<T> : IRepositoryManyToManyBase<T> where T : class
    {
        private readonly ApplicationDBContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public RepositoryManyToManyBase(ApplicationDBContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork(context);
        }

        public async Task<T> AddAsync(T entity)
        {
            if (entity == null)
            {
                return entity;
            }

            try
            {
                _context.Set<T>().Add(entity);
                await _unitOfWork.CommitAsync();

                return entity;
            }
            catch
            {
                return null;
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity == null)
            {
                return entity;
            }

            try
            {
                _context.Set<T>().Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                await _unitOfWork.CommitAsync();

                return entity;
            }
            catch 
            {
                return null;
            }
        }

        public async Task<T> GetByIdByIdAsync(T entity)
        {
            if (entity == null)
            {
                return entity;
            }

            try
            {
                if (entity is PropertyStaff)
                {
                    PropertyStaff ps = entity as PropertyStaff;
                    return (T)_context.Set<PropertyStaff>().Where(x => x.PropertyId == ps.PropertyId && x.StaffId == ps.StaffId);
                }

                return entity;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> DeleteByIdByIdAsync(T entity)
        {
            if (entity == null)
            {
                return false;
            }

            StringBuilder sbSql = new StringBuilder();

            try
            {
                if (entity is PropertyStaff)
                {
                    PropertyStaff ps = entity as PropertyStaff;
                    sbSql.AppendFormat("DELETE FROM PropertyStaff WHERE PropertyId = {0} AND StaffId = {1}", ps.PropertyId, ps.StaffId);
                    await _context.Database.ExecuteSqlRawAsync(sbSql.ToString());
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
