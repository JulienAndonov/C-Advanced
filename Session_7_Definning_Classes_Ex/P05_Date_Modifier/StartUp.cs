using System;
using P05_Date_Modifier;

namespace DefiningClasses
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            DateModifier datemodifier = new DateModifier();
            
            var firstDate = Console.ReadLine();
            var scndDate = Console.ReadLine();

            Console.WriteLine(datemodifier.DifferenceBetweenDates(firstDate, scndDate));


        }
    }
}
