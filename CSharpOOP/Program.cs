using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new instance (object) of the Person class
            var personGui = new Person("Guilherme", 30);

            //Calling a method
            personGui.ChangePersonalData("Gui");

            //Printing the information to the console
            Console.WriteLine(personGui.Name);
            Console.WriteLine(personGui.Age);

            Console.ReadLine();
        }
    }
}
