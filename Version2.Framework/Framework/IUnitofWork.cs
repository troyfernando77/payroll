using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;
using Version2.Framework;

namespace Version2.Framework
{
    public interface IUnitofWork : IDisposable
    {
        Task<bool> Complete();
        Task SaveChangesAsync();
    }
    public class UnitofWork : IUnitofWork
    {
        private readonly Version2Dbcontext _appDbContext;
        private readonly IDbContextTransaction dbContextTransaction;
        public UnitofWork(Version2Dbcontext appDbContext)
        {
            _appDbContext = appDbContext;
            dbContextTransaction = _appDbContext.Database.BeginTransaction();
        }

        public async Task SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
        public async Task<bool> Complete()
        {
            bool returnValue = true;
            try
            {
                await _appDbContext.SaveChangesAsync();
                await dbContextTransaction.CommitAsync();
            }
            catch (Exception err)
            {
                //Log Exception Handling message
                throw new Exception(err.InnerException.Message);
                returnValue = false;
                dbContextTransaction.Rollback();
            }
            return returnValue;
        }

        public void Dispose()
        {
            dbContextTransaction.Dispose();
            _appDbContext.Dispose();
        }
    }
}
