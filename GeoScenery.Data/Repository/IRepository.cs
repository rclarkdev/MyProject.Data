using GeoScenery.Data.Models;

namespace GeoScenery.Data.Repository
{
    public interface IRepository<T> : IRepositoryWithTypedId<T, long>
    {
    }
}
