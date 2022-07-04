using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : User
    {
        public int StudentNumber { get; set; }

        public void CreateUser()
        {
            var student = new Student();
            student.Id = 1;
            student.FirstName = "Hans";
            student.LastName = "Mattin-Lassei";
            student.Email = "hans@domain.com";
            student.StudentNumber = 1;
        }
    }
}
