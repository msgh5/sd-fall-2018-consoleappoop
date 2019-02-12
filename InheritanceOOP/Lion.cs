using System;

namespace InheritanceOOP
{
    //Inheritance
    public class Lion : Animal
    {
        //Override keyword used to override the behavior on the base class
        public override void MakeNoise()
        {
            Console.WriteLine("ROAR!");
        }

        //Override keyword used to override the behavior on the base class
        public override void AskForAttention()
        {
            Console.WriteLine("Lion asking for attention (Careful!)");
        }
    }
}
