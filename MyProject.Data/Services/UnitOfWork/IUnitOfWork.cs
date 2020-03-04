using System;
using System.Collections.Generic;
using System.Text;
using MyProject.Data.Models;
using MyProject.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MyProject.Data.Services
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> UserRepository { get; }
      
        /// <summary>
        /// Commits all changes
        /// </summary>
        Task Commit();
        /// <summary>
        /// Discards all changes that has not been commited
        /// </summary>
        void RejectChanges();
    }
}
