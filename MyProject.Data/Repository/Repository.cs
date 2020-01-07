using MyProject.Data.Context;

namespace MyProject.Data.Repository
{
    public class Repository<T> : RepositoryWithTypedId<T, long>, IRepository<T>
        where T : class
    {
        public Repository(MyProjectDbContext context) : base(context)
        {
        }
    }
}
