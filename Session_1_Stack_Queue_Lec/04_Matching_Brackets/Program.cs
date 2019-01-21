using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Matching_Brackets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    var openBrackedIndex = indexes.Pop();
                    var closedBrackedIndex = i;
                    string expression = input.Substring(openBrackedIndex, closedBrackedIndex - openBrackedIndex + 1);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
