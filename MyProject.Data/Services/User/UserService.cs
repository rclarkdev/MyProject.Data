using System.Linq;
using MyProject.Data.Models;
using System.Collections.Generic;

namespace MyProject.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService()
        {
            _unitOfWork = new UnitOfWork();
        }
        public void Insert(User user)
        {
            _unitOfWork.UserRepository.Add(user);
            _unitOfWork.Commit();
        }

        public void Update()
        {
            _unitOfWork.UserRepository.SaveChange();
        }

        public void Delete(User user)
        {
            _unitOfWork.UserRepository.Remove(user);
            _unitOfWork.Commit();
        }

        public IEnumerable<User> GetAll()
        {
            return _unitOfWork.UserRepository.Query();
        }

        public User GetById(long id)
        {
            return _unitOfWork.UserRepository.Query()
                .FirstOrDefault(/*o => o.Id == id*/);
        }
    }
}