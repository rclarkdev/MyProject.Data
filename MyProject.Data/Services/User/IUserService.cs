using System.Collections.Generic;
using System.Threading.Tasks;
using MyProject.Data.Models;

namespace MyProject.Data.Services
{
    public interface IUserService
    {
        Task Insert(User user);
        Task Update();
        Task Delete(User user);
        Task<List<User>> GetAll();
        Task<User> GetById(long id);
    }
}
