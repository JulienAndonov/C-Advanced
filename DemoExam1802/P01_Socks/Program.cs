using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoExam1802
{
    public class Program
    {
        static void Main(string[] args)
        {
            var leftSide = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var rightSide = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


            var leftSocks = new Stack<int>(leftSide);
            var rightSocks = new Queue<int>(rightSide);

            List<int> pairs = new List<int>();

            while (leftSocks.Any() && rightSocks.Any())
            {
                if (leftSocks.Peek() == rightSocks.Peek())
                {
                    rightSocks.Dequeue();
                    var leftSockValue = leftSocks.Pop();
                    leftSocks.Push(leftSockValue + 1);
                }
                else if (leftSocks.Peek() < rightSocks.Peek())
                {
                    leftSocks.Pop();
                }
                else
                {
                    pairs.Add(leftSocks.Pop() + rightSocks.Dequeue());
                }
            }



            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));

        }
    }
}
