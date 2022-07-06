using _01_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interfaces.Services
{
    internal interface IUserService
    {
        public User Create(string firstName, string lastName, string email);
        public List<User> GetAllUsers();
        public User GetUser(int id);
    }
}
