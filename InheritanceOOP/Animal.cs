using System;

namespace InheritanceOOP
{
    //Abstract classes can't be instanciated
    //Base class for Animals
    public abstract class Animal
    {
        //Methods and properties will be inherited in the Child (Derived) classes.
        public void Eat()
        {
            Console.WriteLine("Eating!");
        }

        public void Walk()
        {
            Console.WriteLine("Walking!");
        }

        //Virtual methods can be overridden in Child (Derived) classes.
        public virtual void MakeNoise()
        {
            Console.WriteLine("Making noise");
        }

        public void MakeMess()
        {
            Console.WriteLine("Making a mess!");
        }

        //Abstract methods MUST be implemented in Child (Derived) classes.
        public abstract void AskForAttention();
    }
}
