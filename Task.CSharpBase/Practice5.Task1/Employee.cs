using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    public class Employee
    {
        protected const double LIVING_SALARY_MINIMUM_IN_RUBLES = 15782;

        protected string name;

        protected double salary;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Имя не может быть пустым");
                }
                name = value;
            }
        }

        public virtual double Salary
        {
            get { return salary; }
            set
            {
                if(value < LIVING_SALARY_MINIMUM_IN_RUBLES)
                {
                    throw new ArgumentException("Зарплата не может быть меньше прожиточного минимума");
                }
                salary = value;
            }
        }

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public Employee(string name) : this(name, LIVING_SALARY_MINIMUM_IN_RUBLES) { }

        public virtual double CalculateBonus()
        {
            return salary * 0.1;
        }

        public virtual string PrintBonusInfo()
        {
            return $"Премия работника {Name}: {CalculateBonus()} руб.";
        }
    }
}
