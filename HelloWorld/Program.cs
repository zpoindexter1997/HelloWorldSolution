//using points to a library of code and points to it for the code, currently pointing to System library (System.TQL.Bootcamp.Class1.Console.WriteLine...)
using System;
//namespace gives a unique name to everything inside of it as a prefix (TQL.Bootcamp.Class1.Console.WriteLine...)
namespace TQL.Bootcamp.Class1 
{//class is a type that defines a block of code in c#, smallest unit in programming. You only put properties and methods into classes
    class Program
    {//static void is a type that declares a method, Main is the name of the method, must have () if it's a method
     //Main method is required in a class to run program, calls to multiple methods within it, once they're all done they go back to main method and program shuts down
        static void Main(string[] args) 
        {
            //var declares a local variable, Variable type named company, value = "string"
            var company = "TQL";
            var student = "Zha'Quon";
            //var in this case automatically declares a local variable, Integer type named yearsWorking because we initialized value = int
            var yearsWorking = 3;
            //Console is a class (in System library) being executed, executing method WriteLine($(calls var)"string {VariableName}")
            Console.WriteLine($"{student} PITY THE FOOL from {company}!");
            Console.WriteLine($"My name is {student} and I've been with {company} for {yearsWorking} years!");
        }
    }
}
