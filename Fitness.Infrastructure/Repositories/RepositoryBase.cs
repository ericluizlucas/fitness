using System.Data;
using Fitness.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Fitness.Infrastructure.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, IBaseEntity
    {
        protected readonly string? ConnectionString;
        
        public RepositoryBase(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
            if(ConnectionString is null) throw new Exception(Common.Messages.Database.ConnectionError);
        }

        public IDbConnection GetOpenConnection()
        {
            IDbConnection connection;
            connection = new MySqlConnection(ConnectionString);
            
            return connection;
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(long id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetByParameter(object whereConditions)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetListByParameter(object whereConditions)
        {
            throw new NotImplementedException();
        }

        public int? Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}