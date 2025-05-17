namespace Practice3.Task9
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Студент. Имя: {Name}, возраст: {Age}";
        }
    }
}
