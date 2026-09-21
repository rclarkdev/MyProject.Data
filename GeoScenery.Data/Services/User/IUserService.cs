using System.Collections.Generic;
using System.Threading.Tasks;
using GeoScenery.Data.Models;

namespace GeoScenery.Data.Services
{
    public interface IUserService
    {
        Task Insert(User user);
        Task Update();
        Task Delete(User user);
        Task<List<User>> GetAll();
        Task<User?> GetById(long id);
    }
}
