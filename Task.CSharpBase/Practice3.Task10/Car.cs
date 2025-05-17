namespace Practice3.Task10
{
    class Car
    {
        public string Brand { get; set; }

        public Car(string brand)
        {
            Brand = brand;
        }

        public static void PrintCarBrand(Car car)
        {
            Console.WriteLine("Машина марки: {0}", car.Brand);
        }
    }
}
