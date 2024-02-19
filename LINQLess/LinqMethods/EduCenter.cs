using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLess.LinqMethods
{
    public class EduCenter
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
