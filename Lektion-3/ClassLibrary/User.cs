using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class User
    {
        protected int Id { get; set; }
        protected string FirstName { get; set; } = null!;
        protected string LastName { get; set; } = null!;
        protected string Email { get; set; } = null!;
    }
}
