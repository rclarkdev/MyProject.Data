using GeoScenery.Data.Context;

namespace GeoScenery.Data.Repository
{
    public class Repository<T> : RepositoryWithTypedId<T, long>, IRepository<T>
        where T : class
    {
        public Repository(MyProjectDbContext context) : base(context)
        {
        }
    }
}
