namespace Practice3.Task1
{
    class Student
    {
        public string name { get; set; }
        public int age { get; set; }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Студент.\nИмя: {name}\nВозраст: {age}";
        }
    }
}
