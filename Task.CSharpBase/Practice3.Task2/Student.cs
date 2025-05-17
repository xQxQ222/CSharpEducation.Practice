namespace Practice3.Task2
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private float averageMark;

        public float AverageMark { get { return averageMark; } set { if (value < 0 || value > 5) throw new Exception(); averageMark = value; } }
    }
}
