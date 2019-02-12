using System;

namespace InheritanceOOP
{
    //Abstract classes can't be instanciated
    //Base class for Animals
    public abstract class Robot
    {
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}
