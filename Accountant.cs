namespace EmployeeApp
{
    class Accountant : Employee
    {
        public int Experience { get; set; }
        public string Qualification { get; set; }

        public Accountant(string name, int age, double baseSalary,
                          int experience, string qualification)
            : base(name, age, baseSalary)
        {
            Experience = experience;
            Qualification = qualification;
        }

        public override double CalculateSalary()
        {
            double percent = Experience * 2;

            if (percent > 20)
            {
                percent = 20;
            }

            return BaseSalary + BaseSalary * percent / 100;
        }

        public override string GetPosition()
        {
            return "Бухгалтер (" + Qualification + ")";
        }
    }
}
