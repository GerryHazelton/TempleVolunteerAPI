namespace TempleVolunteerAPI.Repository
{
    public class UnitOfWorkManyToMany : IDisposable, IUnitOfWorkManyToMany
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

        public Dictionary<Type, object> Repositories
        {
            get { return _repositories; }
            set { Repositories = value; }
        }

        public UnitOfWorkManyToMany(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepositoryManyToManyBase<T> RepositoryManyToMany<T>() where T : class
        {
            try
            {
                if (Repositories.Keys.Contains(typeof(T)))
                {
                    return Repositories[typeof(T)] as IRepositoryManyToManyBase<T>;
                }

                IRepositoryManyToManyBase<T> repository = new RepositoryManyToManyBase<T>(_dbContext);
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
