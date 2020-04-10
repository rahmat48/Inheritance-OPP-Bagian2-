using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.oppbagian2
{
    public class Student : Person

    {
        public Student(string name, int age, string numberid, string email)
        : base(name, age)
        {
            Numberid = numberid;
            Email = email;
        }

        public string Numberid   { get; set; }
        public string Email { get; set; }

    }
}