using System.Collections.Generic;
using MyProject.Data.Models;

namespace MyProject.Data.Services
{
    public interface IUserService
    {
        void Insert(User user);
        void Update();
        void Delete(User user);
        IEnumerable<User> GetAll();
        User GetById(long id);
    }
}
