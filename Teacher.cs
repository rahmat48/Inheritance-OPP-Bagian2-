using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program.oppbagian2
{
    public class Teacher : Person
    {
        public Teacher(string name, int age, string teacherid, string subject)
        : base(name, age)
        {
            TeacherId = teacherid;
            Subject = subject;
        }

        public string TeacherId { get; set; }
        public string Subject { get; set; }

    }
}