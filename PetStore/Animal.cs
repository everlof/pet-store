using System;

namespace PetStore
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        
        public string GetInfo()
        {
            return  $"Id: {Id}, Name: {Name}";
        }

        public string Sleep()
        {
            return "I sleep, ZZZzzz";
        }

        public abstract string MakeNoise();
        
        public virtual string Breathe()
        {
            return "I breathe";
        }
    }
}
