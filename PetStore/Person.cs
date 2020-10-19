using System;
namespace PetStore
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Manual Manual { get; set; }

        public string GetInfo()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
