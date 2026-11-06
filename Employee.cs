namespace EmployeeApp
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double BaseSalary { get; set; }

        public Employee(string name, int age, double baseSalary)
        {
            Name = name;
            Age = age;
            BaseSalary = baseSalary;
        }

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }

        public virtual string GetPosition()
        {
            return "Сотрудник";
        }
    }
}
