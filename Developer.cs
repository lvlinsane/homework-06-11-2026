namespace EmployeeApp
{
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public int CompletedProjects { get; set; }

        public Developer(string name, int age, double baseSalary,
                         string programmingLanguage, int completedProjects)
            : base(name, age, baseSalary)
        {
            ProgrammingLanguage = programmingLanguage;
            CompletedProjects = completedProjects;
        }

        public override double CalculateSalary()
        {
            double percent = CompletedProjects * 5;

            if (percent > 30)
            {
                percent = 30;
            }

            return BaseSalary + BaseSalary * percent / 100;
        }

        public override string GetPosition()
        {
            return "Разработчик (" + ProgrammingLanguage + ")";
        }
    }
}
