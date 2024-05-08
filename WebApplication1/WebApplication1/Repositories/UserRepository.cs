using System;
using WebApplication1.Context;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository() 
        {
            using (var context = new UserContext())
            {
                var users = new List<User>
                {
                new User
                {
                    Id = 1,
                    Name = "Andrei1",
                    Email = "andrei1@gmail.com",
                    Password = "password1",
                },
                new User
                {
                    Id = 2,
                    Name = "Andrei2",
                    Email = "andrei2@gmail.com",
                    Password = "password2",
                },
                new User
                {
                    Id = 3,
                    Name = "Andrei3",
                    Email = "andrei3@gmail.com",
                    Password = "password3",
                },
                new User
                {
                    Id = 4,
                    Name = "Andrei4",
                    Email = "andrei4@gmail.com",
                    Password = "password4",
                },
                };
                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }
        public async Task<List<User>> GetUsersAsync()
        {
            await Task.Delay(10);
            using (var context = new UserContext())
            {
                var list = context.Users
                    .ToList();
                return list;
            }
        }
    }
}
