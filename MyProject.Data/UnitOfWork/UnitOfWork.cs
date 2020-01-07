using System.Linq;
using MyProject.Data.Context;
using MyProject.Data.Models;
using MyProject.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyProjectDbContext _dbContext;

        #region Repositories
        public IRepository<User> UserRepository =>
            new Repository<User>(_dbContext);

        #endregion

        public UnitOfWork()
        {
            _dbContext = new MyProjectDbContext();
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
        public void RejectChanges()
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries()
                .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
    }
}
