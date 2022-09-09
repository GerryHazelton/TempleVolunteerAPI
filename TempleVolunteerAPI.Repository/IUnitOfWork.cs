namespace TempleVolunteerAPI.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryBase<T> Repository<T>() where T : class;
        Task<int> CommitAsync();
        void Rollback();
    }
}
