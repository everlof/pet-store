using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Mammal : Animal
    {
        public string Hair()
        {
            return "We've got hair";
        }

        public string Suckle()
        {
            return "We suckle our young";
        }

        public override string MakeNoise()
        {
            throw new NotImplementedException();
        }
    }
}