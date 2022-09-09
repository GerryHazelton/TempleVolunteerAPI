using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IUnitOfWork _uow;
        private readonly IErrorLogService _errorLog;
        public ServiceBase(IUnitOfWork uow, IErrorLogService errorLog)
        {
            _uow = uow;
            _errorLog = errorLog;
        }

        public async Task<IList<T>> GetAllAsync()
        {
            return await _uow.Repository<T>().GetAllAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _uow.Repository<T>().GetByIdAsync(id);
        }

        public virtual async Task<bool> AddAsync(T entity)
        {
            return await _uow.Repository<T>().AddAsync(entity);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            return await _uow.Repository<T>().UpdateAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            T entity = await _uow.Repository<T>().GetByIdAsync(id);
            return await _uow.Repository<T>().DeleteAsync(entity);
        }

        public async Task ErrorLog(ErrorRequest error)
        {
            await _errorLog.LogError(error);
        }
    }
}
