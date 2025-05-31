using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    public class Contractor : Employee
    {
        private double hourlyRate;

        private int hoursWorked;

        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Почасовая ставка не может быть меньше нуля");
                }
                hourlyRate = value;
            }
        }

        public int HoursWorked
        {
            get { return hoursWorked; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Работник не мог отработать отрицательное количество часов");
                }
                DateTime dateTime = DateTime.Now;
                if (value > DateTime.DaysInMonth(dateTime.Year, dateTime.Month) * 24)
                {
                    throw new ArgumentException("Работник не мог отработать больше часов, чем есть в текущем месяце");
                }
                hoursWorked = value;
            }
        }

        public override double Salary { get => hourlyRate * hoursWorked; }

        public Contractor(string name, double hourlyRate, int hoursWorked) : base(name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        private new double CalculateBonusInfo()
        {
            return 0.00;
        }
    }
}
