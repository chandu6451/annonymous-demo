using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeDemo
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { ID = 101, Name = "Robert" };
            object o = new Employee() { ID = 102, Name = "Maria" };
            var v = new Employee() { ID = 103, Name = "Reena" };


            var person = new { PersonName = "Allister", Age = 30 };
            var person1 = new { PersonName = "Jason", Age = 32 };
            var person2 = new { PersonName = "Tennyson", Age = 31.5 };
            var person3 = new { Age = 28, PersonName = "Daniel" };

            
            Console.ReadKey();
        }
    }
}
