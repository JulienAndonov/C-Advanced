using System;
using System.Collections.Generic;
using System.Linq;


namespace P08_Balanced_Paranthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            Stack<char> paranthesis = new Stack<char>();



            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    paranthesis.Push(input[i]);
                }
                else if (input[i] == ')' && paranthesis.Any())
                {
                    if (paranthesis.Peek() != '(')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        paranthesis.Pop();
                    }
                }
                else if (input[i] == ']' && paranthesis.Any())
                {
                    if (paranthesis.Peek() != '[')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        paranthesis.Pop();
                    }
                }
                else if (input[i] == '}' && paranthesis.Any())
                {
                    if (paranthesis.Peek() != '{')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        paranthesis.Pop();
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }

            }
            Console.WriteLine("YES");
        }
    }
}
