using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program.oppbagian2
{
    public class Person
    {
        public Person(string nama, int usia)
        {
            Name = nama;
            Age = usia;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public void GetNameAndAge()
        {
            Console.WriteLine("Person has name : {0} and age : {1} ", Name, Age);
        }

    }
}