using System;
using System.Collections.Generic;
using System.Linq;

namespace Session_1_Stack_Queue_Lec
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine();
            Stack<char> reversedWords = new Stack<char>(words);


            while (reversedWords.Any())
            {
                Console.Write(reversedWords.Pop());
            }
            Console.WriteLine();
        }
    }
}
