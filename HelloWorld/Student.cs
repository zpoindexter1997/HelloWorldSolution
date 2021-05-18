using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{//Declaring class Student 
    class Student
    {//These are the properties defining the class Student
        //public(who can access this? public means any other class), string type, named FirstName, statement used to get data
        public string FirstName { get; set; }
        //"prop" tab + tab is shortcut for these lines
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool Active { get; set; }
        public DateTime HireDate { get; set; }

        //These are the methods defining the class Student
        //public(any class can access this), void (won't return anything), naming method Print, () must have these with value that we're passing through (in this case nothing)
        public void Print()
        {//This is what happens when we call to method Print
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
