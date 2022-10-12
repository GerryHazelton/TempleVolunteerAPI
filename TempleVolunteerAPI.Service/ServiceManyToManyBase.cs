using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class ServiceManyToManyBase<T> : IServiceManyToManyBase<T> where T : class
    {
        private readonly IUnitOfWorkManyToMany _uow;
        private readonly IErrorLogService _errorLog;
        RepositoryResponse<T> _repositoryResponse;

        public ServiceManyToManyBase(IUnitOfWorkManyToMany uow, IErrorLogService errorLog)
        {
            _uow = uow;
            _errorLog = errorLog;
            _repositoryResponse = new RepositoryResponse<T>();
        }

        public virtual async Task<IList<T>> GetAllAsync(int propertyId, string createdBy)
        {
            _repositoryResponse = await _uow.RepositoryManyToMany<T>().GetAllAsync();

            if (_repositoryResponse.Error != null)
            {
                await _errorLog.LogError(new ErrorRequest
                {
                    FunctionName = "Service: GetAllAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.UtcNow
                });
            }

            return _repositoryResponse.Entities;
        }

        public async Task<T> GetAsync(int id, int propertyId, string createdBy)
        {
            _repositoryResponse = await _uow.RepositoryManyToMany<T>().GetByIdAsync(id);

            if (_repositoryResponse.Error != null)
            {
                await _errorLog.LogError(new ErrorRequest
                {
                    FunctionName = "Service: GetAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.UtcNow
                });
            }

            return _repositoryResponse.Entity;
        }

        public async Task<T> AddAsync(T entity, int propertyId, string createdBy)
        {
            _repositoryResponse = await _uow.RepositoryManyToMany<T>().AddAsync(entity);

            if (_repositoryResponse.Error != null)
            {
                await _errorLog.LogError(new ErrorRequest
                {
                    FunctionName = "Service: AddAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.UtcNow
                });
            }

            return _repositoryResponse.Entity;
        }

        public async Task<T> UpdateAsync(T entity, int propertyId, string createdBy)
        {
            _repositoryResponse = await _uow.RepositoryManyToMany<T>().UpdateAsync(entity);

            if (_repositoryResponse.Error != null)
            {
                await _errorLog.LogError(new ErrorRequest
                {
                    FunctionName = "Service: UpdateAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.UtcNow
                });
            }

            return _repositoryResponse.Entity;
        }

        public async Task<T> DeleteAsync(int id, int propertyId, string createdBy)
        {
            _repositoryResponse = await _uow.RepositoryManyToMany<T>().GetByIdAsync(id);
            _repositoryResponse = await _uow.RepositoryManyToMany<T>().DeleteAsync(_repositoryResponse.Entity);

            if (_repositoryResponse.Error != null)
            {
                await _errorLog.LogError(new ErrorRequest
                {
                    FunctionName = "Service: DeleteAsync",
                    ErrorMessage = _repositoryResponse.Error.Message,
                    StackTrace = _repositoryResponse.Error.StackTrace,
                    PropertyId = propertyId,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.UtcNow
                });
            }

            return _repositoryResponse.Entity;
        }

        public async Task ErrorLog(ErrorRequest error)
        {
            ErrorLog entity = new ErrorLog()
            {
                FunctionName = error.FunctionName,
                ErrorMessage = error.ErrorMessage,
                StackTrace = error.StackTrace,
                PropertyId = error.PropertyId,
                CreatedBy = error.CreatedBy,
                CreatedDate = error.CreatedDate
            };

            var result = await _uow.RepositoryManyToMany<ErrorLog>().AddAsync(entity);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            try
            {
                _repositoryResponse = await _uow.RepositoryManyToMany<T>().FindAsync(match);
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse.Entity;
        }

        public async Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            try
            {
                _repositoryResponse = await _uow.RepositoryManyToMany<T>().FindAllAsync(match);
            }
            catch (Exception ex)
            {
                _repositoryResponse.Error = ex;
            }

            return _repositoryResponse.Entities;
        }
    }
}
