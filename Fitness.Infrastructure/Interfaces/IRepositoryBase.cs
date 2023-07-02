namespace Fitness.Infrastructure.Interfaces
{
    public interface IRepositoryBase<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(long id);
        TEntity GetByParameter(object whereConditions);
        IEnumerable<TEntity> GetListByParameter(object whereConditions);
        int? Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(long id);
    }
}