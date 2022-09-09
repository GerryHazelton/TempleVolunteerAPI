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

        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                await _unitOfWork.CommitAsync();
            }
            catch
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

        public T GetByIdByIdAsync(T entity, int id1, int id2)
        {
            try
            {
                //if (entity is EventsDocuments)  return (T)_context.Set<AreasSupplyItems>().Where(a => a.AreaId == id1 && a.DocumentId == id2);
                //if (entity is AreasSupplyItems)  return (T)_context.Set<AreasSupplyItems>().Where(a => a.AreaId == id1 && a.SupplyItemId == id2);
                //if (entity is Area)  return (T)_context.Set<PropertiesAreas>().Where(p => p.PropertyId == id1 && p.AreaId == id2);
                //if (entity is EventsDocuments)  return (T)_context.Set<EventsDocuments>().Where(p => p.DocumentId == id1 && p.DocumentId == id2);
                //if (entity is PropertiesAreas)  return (T)_context.Set<PropertiesAreas>().Where(p => p.PropertyId == id1 && p.AreaId == id2);
                //if (entity is PropertiesDocuments)  return (T)_context.Set<PropertiesDocuments>().Where(p => p.PropertyId == id1 && p.DocumentId == id2);
                //if (entity is PropertiesSupplyItems) return (T)_context.Set<PropertiesSupplyItems>().Where(p => p.PropertyId == id1 && p.SupplyItemId == id2);
                //if (entity is PropertiesEvents) return (T)_context.Set<PropertiesEvents>().Where(p => p.PropertyId == id1 && p.EventId == id2);
                //if (entity is PropertiesRoles) return (T)_context.Set<PropertiesRoles>().Where(p => p.PropertyId == id1 && p.RoleId == id2);
                //if (entity is PropertiesStaff) return (T)_context.Set<PropertiesStaff>().Where(p => p.PropertyId == id1 && p.StaffId == id2);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
        }

        public async Task<bool> DeleteByIdByIdAsync(T entity, int id1, int id2)
        {
            StringBuilder sbSql = new StringBuilder(); ;

            try
            {
                //if (entity is EventsDocuments) sbSql.AppendFormat("DELETE FROM EventDocuments WHERE EventId = {0} AND DocumentId = {1}", id1, id2);
                //if (entity is AreasSupplyItems) sbSql.AppendFormat("DELETE FROM EventSupplyItems WHERE EventId = {0} AND SupplyItemId = {1}", id1, id2);
                //if (entity is EventsStaff) sbSql.AppendFormat("DELETE FROM EventStaff WHERE EventId = {0} AND StaffId = {1}", id1, id2);
                //if (entity is Area) sbSql.AppendFormat("DELETE FROM EventsAreas WHERE EventId = {0} AND AreaId = {1}", id1, id2);
                //if (entity is EventsDocuments) sbSql.AppendFormat("DELETE FROM EventsDocuments WHERE EventId = {0} AND DocumentId = {1}", id1, id2);
                //if (entity is PropertiesAreas) sbSql.AppendFormat("DELETE FROM PropertiesAreas WHERE PropertyId = {0} AND AreaId = {1}", id1, id2);
                //if (entity is PropertiesDocuments) sbSql.AppendFormat("DELETE FROM PropertiesDocuments WHERE PropertyId = {0} AND DocumentId = {1}", id1, id2);
                //if (entity is PropertiesSupplyItems) sbSql.AppendFormat("DELETE FROM PropertiesSupplyItems WHERE PropertyId = {0} AND SupplyItemId = {1}", id1, id2);
                //if (entity is PropertiesEvents) sbSql.AppendFormat("DELETE FROM PropertiesEvents WHERE PropertyId = {0} AND EventId = {1}", id1, id2);
                //if (entity is PropertiesRoles) sbSql.AppendFormat("DELETE FROM PropertiesRoles WHERE PropertyId = {0} AND RoleId = {1}", id1, id2);
                //if (entity is PropertiesStaff) sbSql.AppendFormat("DELETE FROM PropertiesStaff WHERE PropertyId = {0} AND StaffId = {1}", id1, id2);

                await _context.Database.ExecuteSqlRawAsync(sbSql.ToString());

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
