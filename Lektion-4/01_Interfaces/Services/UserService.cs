using _01_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interfaces.Services
{
    internal class UserService : IUserService
    {
        private List<User> _users = new List<User>();

        public User Create(string firstName, string lastName, string email)
        {
            var user = new User(_users.Count + 1, firstName, lastName, email);
            _users.Add(user);
            return user;
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUser(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }

        public void Delete(int id)
        {
            _users = _users.Where(user => user.Id != id).ToList();
        }
    }
}
