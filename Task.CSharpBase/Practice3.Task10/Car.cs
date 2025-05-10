using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task10
{
    class Car
    {
        public string Brand {  get; set; }

        public Car(string brand)
        {
            Brand = brand;
        }

        public static void PrintCarBrand(Car car)
        {
            Console.WriteLine("Машина марки: {0}",car.Brand);
        }
    }
}
