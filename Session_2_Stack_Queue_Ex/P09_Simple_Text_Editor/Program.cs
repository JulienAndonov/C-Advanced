using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P09_Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());
            Stack<string> versions = new Stack<string>();
            StringBuilder text = new StringBuilder();


            for (int i = 0; i < numOfOperations; i++)
            {
                var tokens = Console.ReadLine().Split();
                int command = int.Parse(tokens[0]);

                switch (command)
                {
                    case 1:
                        versions.Push(text.ToString());
                        string toAppend = tokens[1];
                        text.Append(tokens[1]);
                        break;
                    case 2:
                        versions.Push(text.ToString());
                        int toErase = int.Parse(tokens[1]);
                        text.Remove(text.Length - toErase, toErase);
                        break;
                    case 3:
                        int index = int.Parse(tokens[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        text.Clear();
                        text.Append(versions.Pop());
                        break;
                }
            }




        }
    }
}
