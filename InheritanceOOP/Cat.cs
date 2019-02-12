using System;

namespace InheritanceOOP
{
    //Inheritance
    public class Cat : Animal
    {
        //Override keyword used to override the behavior on the base class
        public override void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }

        //Override keyword used to override the behavior on the base class
        public override void AskForAttention()
        {
            Console.WriteLine("Cat asking for attention");
        }
    }
}
