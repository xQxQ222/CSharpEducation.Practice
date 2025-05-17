namespace PersonLibrary
{
    public class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                if(value == null || value.Trim().Equals(""))
                {
                    throw new ArgumentException("Имя не должно быть пустым");
                }
                _name = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Возраст должен быть в пределах от 0 до 120 лет!");
                }
                _age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string name) : this(name, 18) { }

        public override string ToString()
        {
            string sub = _age % 10 == 1 ? "год" : (_age%10<5 && _age%10>0 ? "года" : "лет");
            return $"{_name}, {_age} {sub}";
        }
    }
}
