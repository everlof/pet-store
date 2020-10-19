namespace PetStore
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Manual Manual { get; set; }
        public int PayPerHour { get; set; }
        public int VacationDays { get; set; }

        public int Salary(int hours)
        {
            return PayPerHour * hours;
        }
        public string GetInfo()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
