namespace TempleVolunteerAPI.Repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

        public Dictionary<Type, object> Repositories
        {
            get { return _repositories; }
            set { Repositories = value; }
        }

        public UnitOfWork(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepositoryBase<T> Repository<T>() where T : class
        {
            try
            {
                if (Repositories.Keys.Contains(typeof(T)))
                {
                    return Repositories[typeof(T)] as IRepositoryBase<T>;
                }

                IRepositoryBase<T> repository = new RepositoryBase<T>(_dbContext);
                Repositories.Add(typeof(T), repository);

                return repository;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> CommitAsync()
        {
            try
            {
                return await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

        public void Rollback()
        {
            _dbContext.Dispose();
        }
    }
}
