using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Bird : Animal
    {
        public override string MakeNoise()
        {
            return ("Chirp");
        }

        public string Breathe()
        {
            return "I have lungs";
        }
    }
}
