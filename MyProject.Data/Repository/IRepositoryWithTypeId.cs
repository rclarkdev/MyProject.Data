using System.Linq;
using MyProject.Data.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace MyProject.Data.Repository
{
    public interface IRepositoryWithTypedId<T, in TId>
    {
        IQueryable<T> Query();

        void Add(T entity);

        IDbContextTransaction BeginTransaction();

        void SaveChange();

        void Remove(T entity);
    }
}
