using System;
using System.Data.SqlClient;
using System.Linq;
using MyProject.Data.Models;
using MyProject.Data.UnitOfWork;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;

namespace MyProject.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService()
        {
            _unitOfWork = new UnitOfWork.UnitOfWork();
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

        public IQueryable<User> GetAll()
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