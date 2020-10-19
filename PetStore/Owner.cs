namespace PetStore
{
    public class Owner : IEmployee, IManager
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Manual Manual { get; set; }
        public int PayPerHour { get; set; }
        public int VacationDays { get; set; }
        public int Salary(int hours)
        {
            return PayPerHour * hours + 1000;
        }

        public string GetInfo()
        {
            return $"Title: Owner and Manager, Name: {Name}, Age: {Age}";
        }

        public string BossAround()
        {
            return ("I do bossy things");
        }
    }
}
