using System;

namespace GenericScale
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var a = "5";
            var b = "5";

            var equalityScales = new EqualityScale<string>(a,b);
            Console.WriteLine(equalityScales.isEqual);
        }
    }
}
