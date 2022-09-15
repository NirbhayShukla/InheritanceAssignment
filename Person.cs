using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    internal class Person
    {
        public string fName, lName, email;
        DateTime dob;

        public Person(string fName,string lName,string email, DateTime dob)
        {
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.dob = dob;
        }

        public Person(string fName, string lName, string email)
        {
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.dob = DateTime.Now;
        }

        public Person(string fName, string lName, DateTime dob)
        {
            this.fName = fName;
            this.lName = lName;
            this.dob = dob;
            this.email = "";
        }

        public void show()
        {
            Console.WriteLine($"Name = {fName} {lName} , Email = {email} ,DOB ={dob.ToString()}");
        }

        static void Main(string[] args)
        {
            Person p = new Person("Nirbhay", "Shukla", "email@gmail", new DateTime(2000, 3, 7));
            p.show();
        }
    }
}
