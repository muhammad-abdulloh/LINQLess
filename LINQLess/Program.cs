using static System.Formats.Asn1.AsnWriter;
using System.Linq;
using LINQLess.LinqMethods;

namespace LINQLess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Join
            var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John" },
            new Employee { Id = 2, Name = "Alice" },
            new Employee { Id = 3, Name = "Bob" }
        };
            var departments = new List<Department>
        {
            new Department { Id = 1, DName = "HR" },
            new Department { Id = 2, DName = "Finance" }
        };
            var joinedData = employees.Join(departments, emp => emp.Id, dept => dept.Id, (emp, dept) => new { emp.Name, dept.DName });
            Console.WriteLine("Join:");
            foreach (var item in joinedData)
            {
                Console.WriteLine($"{item.Name} - {item.DName}");
            }
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Department
    {
        public int Id { get; set; }
        public string DName { get; set; }
    }
}
