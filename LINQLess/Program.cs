using static System.Formats.Asn1.AsnWriter;
using System.Linq;
using LINQLess.LinqMethods;

namespace LINQLess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4, 0, 6
            };

            List<string> numbers2 = new List<string>()
            {
                "item1", "item2", "item3"
            };


            List<int> numbers22 = new List<int>()
            {
                4, 12, 13, 14, 15, 0, 5, 1 ,16, 17, 18, 19, 20, 21, 22
            };

            LINQForEduCenter data = new LINQForEduCenter();

            var centers = data.GetAll();

            // arrayni o'zini o'zgartirvoryabdi
            var number = numbers2[907385826];

            Console.WriteLine(number);


            //foreach (var number in result)
            //{
            //    Console.Write(number + " ");
            //}

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
