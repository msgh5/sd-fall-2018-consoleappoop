using System;

namespace InheritanceOOP
{
    //Inheritance
    public class Dog : Animal
    {
        //Override keyword used to override the behavior on the base class
        public override void MakeNoise()
        {
            //Calling base method on the Base class before executing our own behavior
            base.MakeNoise();
            Console.WriteLine("WOOF WOOF!");
        }

        //Override keyword used to override the behavior on the base class
        public override void AskForAttention()
        {
            Console.WriteLine("Dog asking for attention");
        }
    }
}
