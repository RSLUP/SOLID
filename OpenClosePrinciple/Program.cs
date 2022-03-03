using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new ContractEmployee(1, "John");
            Employee emp2 = new PermentntEmployee(1, "Smith");

            Console.WriteLine($"Employee: {emp1.Name} Bonus: {emp1.CalcualateBonus(10000)}");
            Console.WriteLine($"Employee: {emp2.Name} Bonus: {emp2.CalcualateBonus(10000)}");

            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalcualateBonus(decimal salary);
    }

    public class ContractEmployee : Employee
    {
        public ContractEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalcualateBonus(decimal salary)
        {
            return salary * 0.6M;
        }
    }

    public class PermentntEmployee : Employee
    {
        public PermentntEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalcualateBonus(decimal salary)
        {
            return salary * 0.8M;
        }
    }
}
