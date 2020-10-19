using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Snake : Reptile
    {
        public string NoLegs()
        {
            return ("I don't have any legs");
        }

        public override string MakeNoise()
        {
            return ("Hissing");
        }

        public override string Breathe()
        {
            return "Some of us can breathe through the skin, but most of us have lungs";
        }
    }
}
