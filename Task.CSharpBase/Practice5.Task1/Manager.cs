namespace Practice5.Task1
{
    public sealed class Manager : Employee
    {

        private int teamSize;

        public int TeamSize
        {
            get { return teamSize; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Размер команды не может быть меньше 0 человек");
                }
                teamSize = value;
            }
        }

        public Manager(string name, int teamSize) : base(name)
        {
            TeamSize = teamSize;
        }
        public Manager(string name, double salary, int teamSize) : base(name, salary)
        {
            TeamSize = teamSize;
        }

        public override double CalculateBonus()
        {
            return teamSize > 5 ? salary * 0.25 : salary * 0.2;
        }

        public override string PrintBonusInfo()
        {
            return $"Премия менеджера {Name} с командой из {TeamSize} чел.: {CalculateBonus()} руб.";
        }
    }
}
