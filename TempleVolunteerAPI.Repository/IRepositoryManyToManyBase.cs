namespace TempleVolunteerAPI.Repository
{
    public interface IRepositoryManyToManyBase<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        T GetByIdByIdAsync(T entity, int id1, int id2);
        Task<bool> DeleteByIdByIdAsync(T entity, int id1, int id2);
    }
}
