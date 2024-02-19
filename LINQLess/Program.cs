using static System.Formats.Asn1.AsnWriter;
using System.Linq;
using LINQLess.LinqMethods;

namespace LINQLess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LINQForEduCenter data = new LINQForEduCenter();
            //foreach (var item in data.GetCenterByName("Najot Ta'lim"))
            //{
            //    var empoyees = item.Employees.Select(x => x).Where(z => z.Experience > 5);
            //    Console.WriteLine(item.Name);
            //    foreach(var employee in empoyees)
            //    {
            //        Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //    }
            //}

            //foreach(var item in data.GetCenterByNameWithExperience())
            //{
            //    Console.WriteLine(item.FirstName + " " + item.Experience);
            //}


            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4, 5, 657,45 ,567,5,75,7,5,8,68,6, 0,78,6,6,9,9 ,3412 ,978 ,9,789,2342,637,213
            };

            List<int> numbers2 = new List<int>()
            {
                2, 1, 3, 4, 5, 657,45 ,567,5,75,7,5,8,68,6, 0,78,6,6,9,9 ,3412 ,978 ,9,789,2342,637,213
            };

            var result = numbers.SequenceEqual(numbers2);

            Console.WriteLine(result);
        }
    }
}
