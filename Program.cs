using System;
using System.Text;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Developer dev = new Developer("Иван", 25, 100000, "C#", 8);
            Manager man = new Manager("Анна", 35, 120000, 10, 20000);
            Accountant acc = new Accountant("Ольга", 40, 80000, 5, "Высшая");

            Employee[] employees = { dev, man, acc };

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name + " - " + e.GetPosition());
                Console.WriteLine("Зарплата: " + e.CalculateSalary());
                Console.WriteLine();
            }
        }
    }
}
