using MyProject.Data.Context;
using MyProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MyProjectDbContext context)
        {
            if (!context.User.Any())
            {
                SeedUser(context);
            }
        }

      


        private static void SeedUser(MyProjectDbContext context)
        {
            var user = new User()
            {
            };

            context.Add(user);
            context.SaveChanges();
        }
    }
}
