//using points to a library of code and points to it for the code, currently pointing to System library (System.TQL.Bootcamp.Class1.Console.WriteLine...)
using System;
//using namespace HelloWorld
using HelloWorld;
//namespace gives a unique name to everything inside of it as a prefix (TQL.Bootcamp.Class1.Console.WriteLine...)
namespace TQL.Bootcamp.Class1 
{//class is a type that defines a block of code in c#, smallest unit in programming. You only put properties and methods into classes
    class Program
    {//static void is a property type that declares a method, Main is the name of the method, must have () if it's a method
     //Main method is required in a class to run program, calls to multiple methods within it, once they're all done they go back to main method and program shuts down
        static void Main(string[] args) 
        {
            //declaring variable sarah, setting = to a new instance from the Student Class (from namespace HelloWorld)
            var sarah = new Student();
           //sarah.____ goes to Student class and pulls that property to insert this value
            sarah.FirstName = "Sarah";
            sarah.LastName = "George";

            var charlie = new Student();
            charlie.FirstName = "Charlie";
            charlie.LastName = "Traylor";

            var mattea = new Student();
            mattea.FirstName = "Mattea";
            mattea.LastName = "Swain";
            //From variable sarah, call Print method (from Student class)
            sarah.Print();
            charlie.Print();
            mattea.Print();

            //var declares a local variable, Variable type named company, value = "string"
            var company = "TQL";
            var student = "Zha'Quon";
            //var in this case automatically declares a local variable, Integer type named yearsWorking because we initialized value = int
            var yearsWorking = 3;
            //Types can only be null by adding an ? on the end
            int? i = null;
            //Console is a class (in System library) being executed, executing method WriteLine($(calls var)"string {VariableName}")
            Console.WriteLine($"{student} PITY THE FOOL from {company}!");
            Console.WriteLine($"My name is {student} and I've been with {company} for {yearsWorking} years!");
        }
    }
}
