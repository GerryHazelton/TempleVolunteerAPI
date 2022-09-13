namespace TempleVolunteerAPI.Repository
{
    public interface IUnitOfWorkManyToMany : IDisposable
    {
        IRepositoryManyToManyBase<T> RepositoryManyToMany<T>() where T : class;
        Task<int> CommitAsync();
        void Rollback();
    }
}
