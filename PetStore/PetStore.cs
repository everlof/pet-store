using System;

namespace PetStore
{
    public class PetStore
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
        public bool Open { get; set; }
        public Person[] Employees { get; set; }

        public Animal[] Animals { get; set; }

        public string GetInfo()
        {
            return $"Owner of {Name} is {Owner.Name}";
        }

        public string GetStatus()
        {
            string status = Open ? "open" : "closed";
            return $"{Name} is {status}";
        }

        public string GetEmployeeInfo()
        {
            string info = "Employees: "+ Environment.NewLine;
            for (int i = 0; i < Employees.Length; i++)
            {
                info = info + Employees[i].GetInfo() + Environment.NewLine;
            }

            return info;
        }

        public string GetAnimalInfo()
        {
            string info = "Animals: " + Environment.NewLine;
            for (int i = 0; i < Animals.Length; i++)
            {
                info = info + Animals[i].GetInfo() + Environment.NewLine;
            }

            return info;
        }
    }
}
