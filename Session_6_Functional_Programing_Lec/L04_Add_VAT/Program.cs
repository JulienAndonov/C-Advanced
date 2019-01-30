using System;
using System.Linq;

namespace L04_Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(x => x + (20 * x) / 100).ToList().ForEach(x => Console.WriteLine($"{x:F2}")) ;
        }
    }
}
