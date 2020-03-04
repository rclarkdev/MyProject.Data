using System.Linq;
using MyProject.Data.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace MyProject.Data.Repository
{
    public interface IRepositoryWithTypedId<T, in TId>
    {
        IQueryable<T> Query();

        void Add(T entity);

        IDbContextTransaction BeginTransaction();

        Task SaveChangeAsync();

        void Remove(T entity);
    }
}
