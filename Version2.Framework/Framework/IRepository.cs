using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Data.Models;

namespace Version2.Framework
{
    
    public class Entity : IEntity
    {
        public int Id { get; set; }
    }
    public interface IRepository<T> where T:class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Query { get; }
        Task<int> AddGetId(IEntity entity);

        Task Add(IEntity entity);

        Task Delete(T entity);
        Task SaveAsyc();
        Task Update(T entity);
        Task Deletes(IEnumerable<T> entities);
    }
    
    public class Repository<T> :IRepository<T> where T : class 
    {
        Version2Dbcontext db;
        public Repository(Version2Dbcontext db)
        {
            this.db = db;
        }
       
        #region IRepository<T> Members

        public IQueryable<T> Query
        {
            get { return db.Set<T>(); }
        }

        public IQueryable<T> GetAll()
        {
            return Query;
        }

        public async Task<int> AddGetId(IEntity entity)
        {
            db.Add(entity);
            await SaveAsyc();
            return entity.Id;
        }
        public Task Add(IEntity entity)
        {
            db.Add(entity);
            return Task.CompletedTask;
        }
        public Task Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
        public   Task Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            return Task.CompletedTask;

        }
        public   Task Deletes(IEnumerable<T> entities)
        {
            db.Set<T>().RemoveRange(entities);
            return Task.CompletedTask;
        }

        public async Task SaveAsyc()
        {
            await db.SaveChangesAsync();
        }

        #endregion
    }
}
