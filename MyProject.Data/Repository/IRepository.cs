using MyProject.Data.Models;

namespace MyProject.Data.Repository
{
    public interface IRepository<T> : IRepositoryWithTypedId<T, long>
    {
    }
}
