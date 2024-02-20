using static System.Formats.Asn1.AsnWriter;
using System.Linq;
using LINQLess.LinqMethods;
using Newtonsoft.Json;

namespace LINQLess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            // Join
            var employees = new List<Employee>
                {
                    new Employee { Id = 1, EName = "John", DepartmentId = 1 },
                    new Employee { Id = 2, EName = "Alice", DepartmentId = 1 },
                    new Employee { Id = 3, EName = "Bob", DepartmentId = 2 },
                    new Employee { Id = 4, EName = "Jack", DepartmentId = 1 },
                    new Employee { Id = 5, EName = "Toms", DepartmentId = 2 },
                    new Employee { Id = 6, EName = "Ron", DepartmentId = 1 },
                    new Employee { Id = 7, EName = "Ram", DepartmentId = 2 },
                    new Employee { Id = 8, EName = "Devid", DepartmentId = 2 },
                };

            var departments = new List<Department>
                {
                    new Department { Id = 1, DName = "HR" },
                    new Department { Id = 2, DName = "Programming" }
                };

            var joinedData = departments
                .GroupJoin(employees, dept => dept.Id , emp => emp.DepartmentId, 
                                   (dept, emps) => new { DepartmentName = dept.DName, Employees = emps });
            
            Console.WriteLine("Join:");
            
            foreach (var item in joinedData)
            {
                Console.WriteLine($"{item.DepartmentName} - {JsonConvert.SerializeObject(item.Employees, Formatting.Indented)}");
            }

        

        }
    }

    class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string EName { get; set; }
    }

    class Department
    {
        public int Id { get; set; }
        public string DName { get; set; }
    }

    class EmployeeDepartment
    {
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set;}
        public string DepartmentName { get; set;}
    }
}
