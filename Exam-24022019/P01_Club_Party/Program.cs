    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace ExamAdvanced
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                int capacity = int.Parse(Console.ReadLine());
                Queue<char> rooms = new Queue<char>();
                Queue<int> peopleInARoom = new Queue<int>();

                var input = Console.ReadLine().Split().ToList();
                input.Reverse();


                for (int i = 0; i < input.Count; i++)
                {
                    if (char.IsLetter(input[i][0]))
                    {
                        rooms.Enqueue(char.Parse(input[i]));
                    }
                    else if(rooms.Any())
                    {
                        var currentEntry = int.Parse(input[i]);
                        if (peopleInARoom.Sum() + currentEntry <= capacity)
                        {
                            peopleInARoom.Enqueue(currentEntry);
                        }
                        else
                        {
                            Console.WriteLine($"{rooms.Dequeue()} -> {string.Join(", ",peopleInARoom)}");
                            peopleInARoom.Clear();
                            peopleInARoom.Enqueue(currentEntry);
                        }

                        if (!rooms.Any())
                        {
                            break;
                        }



                    }
                    
                }
            }
        }
    }

