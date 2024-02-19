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
            

            List<int> numbers = new List<int>()
            {
                1, 2, 2, 3, 3, 4, 5, 6
            };

            List<int> numbers2 = new List<int>()
            {
                5, 6, 7, 8, 8, 9, 1
            };


            Console.WriteLine(numbers2.Average());
        }
    }
}
