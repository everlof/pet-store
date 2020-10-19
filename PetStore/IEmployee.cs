using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public interface IEmployee
    {
        string Name { get; set; }
        int Age { get; set; }
        Manual Manual { get; set; }
        int PayPerHour { get; set; }
        int VacationDays { get; set; }
        int Salary(int hours);
        string GetInfo();

    }
}
