namespace Practice3.Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Иван";
            student.Age = 20;
            Console.WriteLine(student);
            MakeStudentAnonymous(student);
            Console.WriteLine(student);
        }

        private static Student MakeStudentAnonymous(Student student)
        {
            student.Name = "Аноним";
            return student;
        }
    }
}