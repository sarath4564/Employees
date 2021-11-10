using System;
namespace Employees
{
    public class Employees
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Salary { get; private set; }

        public static void Main()
        {
            Employees employees = GetEmployees();
            Console.WriteLine(employees);
        }

        private static Employees GetEmployees()
        {
            return NewMethod();
        }

        private static Employees NewMethod()
        {
            return new Employees { Id = 1001, Name = "Ashok", Salary = 98000 };
        }
    }
}