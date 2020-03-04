using System.Linq;
using MyProject.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService()
        {
            _unitOfWork = new UnitOfWork();
        }
        public async Task Insert(User user)
        {
            _unitOfWork.UserRepository.Add(user);
            await _unitOfWork.Commit();
        }

        public async Task Update()
        {
            await _unitOfWork.UserRepository.SaveChangeAsync();
        }

        public async Task Delete(User user)
        {
            _unitOfWork.UserRepository.Remove(user);
            await _unitOfWork.Commit();
        }

        public async Task<List<User>> GetAll()
        {
            return await _unitOfWork.UserRepository.Query().ToListAsync();
        }

        public async Task<User> GetById(long id)
        {
            return await _unitOfWork.UserRepository.Query()
                .FirstOrDefaultAsync(/*o => o.Id == id*/);
        }
    }
}