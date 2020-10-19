using System;

namespace PetStore
{
    public class Program
    {
        static void Main(string[] args)
        {

            Fish[] fishes = { new Fish { Id = 4, Name = "Wanda" }, new Fish { Id = 5, Name = "Adam" }, new Fish { Id = 6, Name = "Robin" } };

            Animal[] animals = {new Fish{ Id = 4, Name = "Hagrid" },
                                new Snake{ Id = 7, Name = "Kaa" },
                                new Bird { Id = 8, Name = "Gene" } };

            Manual manual = new Manual { OpenHours = "9-18" };
            IEmployee roland = new Employee { Name = "Roland Björk", Age = 26, Manual = manual, PayPerHour = 200, VacationDays = 30 };
            IEmployee gabriella = new Employee { Name = "Gabriella Holmberg", Age = 39, Manual = manual, PayPerHour = 230, VacationDays = 35 };

            //På samma sätt som vid arv kan du skapa upp en array av typen IEmployee.
            //I det här exemplet har det ingen större betydelse då båda instanserna är av samma klass.
            IEmployee[] employees = { roland, gabriella };

            Console.WriteLine(roland.GetInfo());
            Console.WriteLine("salary: " + roland.Salary(160));
            Console.WriteLine("vacation days: " + roland.VacationDays);

            Console.WriteLine("----------------------");
            Console.WriteLine(gabriella.GetInfo());
            Console.WriteLine("salary: " + gabriella.Salary(160));
            Console.WriteLine("vacation days: " + gabriella.VacationDays);

            Console.WriteLine("----------------------");


            Owner goran = new Owner { Name = "Göran Persson", Age = 58, Manual = manual, PayPerHour = 300, VacationDays = 35 };

            Console.WriteLine(goran.GetInfo());
            Console.WriteLine("salary: " + goran.Salary(160));
            Console.WriteLine("vacation days: " + goran.VacationDays);
            Console.WriteLine(goran.BossAround());


            Console.ReadLine();
        }
    }
}

