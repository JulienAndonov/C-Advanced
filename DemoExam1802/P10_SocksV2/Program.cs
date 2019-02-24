using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_SocksV2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> leftSocks = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> rightSocks = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            List<int> pairs = new List<int>();


            while (leftSocks.Any() && rightSocks.Any())
            {
                var currentLeftSock = leftSocks.Pop();

                if (currentLeftSock > rightSocks.Peek())
                {
                    var pairValue = currentLeftSock + rightSocks.Dequeue();
                    pairs.Add(pairValue);
                }
                else if (rightSocks.Peek() > currentLeftSock)
                {
                    continue;
                }
                else
                {
                    rightSocks.Dequeue();
                    currentLeftSock += 1;
                    leftSocks.Push(currentLeftSock);
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}
