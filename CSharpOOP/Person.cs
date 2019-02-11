using System;

namespace CSharpOOP
{
    //Person class
    public class Person
    {
        //Properties
        public string Name { get; private set; }
        public int Age { get; private set; }

        //Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Constructor
        public Person(string name)
        {
            Name = name;
            Age = 18;
        }

        //Method
        public void ChangePersonalData(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name needs to be specified");
            }

            Name = name;
        }

        //Method Overload
        public void ChangePersonalData(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
