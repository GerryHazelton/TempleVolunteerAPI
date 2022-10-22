namespace TempleVolunteerAPI.Repository
{
    public interface IRepositoryWrapperManyToMany : IDisposable
    {
        IRepositoryManyToManyBase<T> RepositoryManyToMany<T>() where T : class;
        Task<int> CommitAsync();
        void Rollback();
    }
}
