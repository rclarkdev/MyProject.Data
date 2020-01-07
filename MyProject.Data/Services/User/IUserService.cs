using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyProject.Data.Models;

namespace MyProject.Data.Services
{
    public interface IUserService
    {
        void Insert(User user);
        void Update();
        void Delete(User user);
        IQueryable<User> GetAll();
        User GetById(long id);
    }
}
