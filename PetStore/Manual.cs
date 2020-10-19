using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Manual
    {
        public string OpenHours { get; set; }

        public string GetOpenHours()
        {
            return $"Openhours: {OpenHours}";
        }
    }
}
