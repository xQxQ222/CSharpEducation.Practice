using System;
using System.Security.Cryptography.X509Certificates;
namespace Practice5.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Роман");
            Manager manager = new Manager("Григорий", 0);
            Manager managerWithTeam = new Manager("Алексей", 7);
            Contractor contractor = new Contractor("Иван", 561.84, 85);

            Console.WriteLine(employee.PrintBonusInfo());
            Console.WriteLine(manager.PrintBonusInfo());
            Console.WriteLine(managerWithTeam.PrintBonusInfo());

            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(manager);
            employees.Add(managerWithTeam);
            employees.Add(contractor);

            foreach (var e in employees)
            {
                if (e is not Contractor)
                {
                    Console.WriteLine(e.PrintBonusInfo());
                }
                else
                {
                    Console.WriteLine($"{e.Name}, бонуса нет! Работа идет с почасовой ставкой. Твоя полная зарплата за этот месяц: {Math.Round(e.Salary, 2)} руб.");
                }
            }
        }
    }
}