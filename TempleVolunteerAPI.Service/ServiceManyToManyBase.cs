using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class ServiceManyToManyBase<T> : IServiceManyToManyBase<T> where T : class
    {
        private readonly IUnitOfWorkManyToMany _uow;
        private readonly IErrorLogService _errorLog;
        public ServiceManyToManyBase(IUnitOfWorkManyToMany uow, IErrorLogService errorLog)
        {
            _uow = uow;
            _errorLog = errorLog;
        }

        public async Task<T> AddAsync(T entity, int propertyId, string createdBy)
        {
            try
            {
                return await _uow.RepositoryManyToMany<T>().AddAsync(entity);
            }
            catch (Exception ex)
            {
                await _errorLog.LogError(new ErrorRequest
                {
                    FunctionName = "Service: AddAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.UtcNow
                });

                throw;
            }
        }

        public async Task<T> UpdateAsync(T entity, int propertyId, string createdBy)
        {
            try
            {
                return await _uow.RepositoryManyToMany<T>().UpdateAsync(entity);
            }
            catch (Exception ex)
            {
                await _errorLog.LogError(new ErrorRequest
                {
                    FunctionName = "Service: UpdateAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.UtcNow
                });

                throw;
            }
        }

        public async Task<bool> DeleteByIdByIdAsync(T entity, int propertyId, string createdBy)
        {
            try
            {
                return await _uow.RepositoryManyToMany<T>().DeleteByIdByIdAsync(entity);
            }
            catch (Exception ex)
            {
                await _errorLog.LogError(new ErrorRequest
                {
                    FunctionName = "Service: DeleteAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.UtcNow
                });

                throw;
            }
        }

        public async Task<T> GetByIdByIdAsync(T entity, int propertyId, string createdBy)
        {
            try
            {
                return await _uow.RepositoryManyToMany<T>().GetByIdByIdAsync(entity);
            }
            catch (Exception ex)
            {
                await _errorLog.LogError(new ErrorRequest
                {
                    FunctionName = "Service: DeleteAsync",
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.UtcNow
                });

                throw;
            }
        }

        public async Task ErrorLog(ErrorRequest error)
        {
            await _errorLog.LogError(error);
        }
    }
}
