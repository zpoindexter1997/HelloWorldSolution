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
        //Private means only this class (Student) can edit this property
        private DateTime HireDate { get; set; }

        //These are the methods defining the class Student
        //public, void, named SetHireDate(DataType Name, DataType Name, DataType Name)
        public void SetHireDate(int year, int month, int day)
        {//if(boolean is true, run this)  (year is < 1950 OR year > 2200)
            if (year < 1950 || year > 2200)
            {
                Console.WriteLine($"Put a real year dude... 1950 - 2200");
                //return means don't continue 
                return;
            }
            if (month < 1 || month > 12)
            {
                Console.WriteLine($"There's only 12 months bro... 1<= x <= 12");
                return;
            }
            if (day < 1 || day > 31)
            {
                Console.WriteLine($"There's no month with that many days!");
                return;
            }
            //if none of the above ifs are true, set HireDate = to new DataType (values)
            HireDate = new DateTime(year, month, day);
        }
        //public(any class can access this), void (won't return anything), naming method Print, () must have these with value that we're passing through (in this case nothing)
        public void Print()
        {//This is what happens when we call to method Print
            //in console, writeline method($"(value) (value) Hired: {calls to HireDate, formats as string("month/day/year")}")
            Console.WriteLine($"{FirstName} {LastName} Hired: { HireDate.ToString("MM/dd/yyyy")}");
        }
    }
}
