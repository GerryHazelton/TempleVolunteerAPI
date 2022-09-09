using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class ServiceManyToManyBase<T> : IServiceManyToManyBase<T> where T : class
    {
        private readonly IUnitOfWork _uow;
        private readonly IErrorLogService _errorLog;
        public ServiceManyToManyBase(IUnitOfWork uow, IErrorLogService errorLog)
        {
            _uow = uow;
            _errorLog = errorLog;
        }

        public async Task<bool> AddAsync(T entity, string userId)
        {
            var result = await _uow.Repository<T>().AddAsync(entity);

            if (result != null)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(T entity, string userId)
        {
            return await _uow.Repository<T>().UpdateAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id, string userId)
        {
            T entity = await _uow.Repository<T>().GetByIdAsync(id);
            return await _uow.Repository<T>().DeleteAsync(entity);
        }

        public async Task ErrorLog(ErrorRequest error)
        {
            await _errorLog.LogError(error);
        }

        public Task<bool> GetByPropertyIdEventIdAsync(int propertyId, int EventId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
