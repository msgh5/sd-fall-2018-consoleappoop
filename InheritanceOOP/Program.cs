using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dog = new Dog();
            //dog.Bark();
            //dog.Eat();
            //dog.Walk();

            //var cat = new Cat();
            //cat.Meow();
            //cat.Eat();
            //cat.Walk();

            //var lion = new Lion();
            //lion.Roar();
            //lion.Eat();
            //lion.Walk();

            var animalList = new List<Animal>();
            animalList.Add(new Dog());
            animalList.Add(new Cat());
            animalList.Add(new Lion());
            
            foreach(var animal in animalList)
            {
                animal.MakeNoise();
                animal.Eat();
                animal.Walk();
                animal.AskForAttention();
            }

            Console.ReadLine();
                
        }
    }
}
