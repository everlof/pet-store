using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Fish : Animal
    {
        public override string MakeNoise()
        {
            return ("Nemo, where are you?!");
        }

        public override string Breathe()
        {
            return "I breathe with gills";
        }
    }
}
