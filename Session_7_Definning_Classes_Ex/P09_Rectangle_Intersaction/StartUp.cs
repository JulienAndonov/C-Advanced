using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            var inputEntries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var numOfRectangles = inputEntries[0];
            var numOfChecks = inputEntries[1];
            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < numOfRectangles; i++)
            {
                var rectangleVariables = Console.ReadLine().Split(" ");
                var rectangleID = rectangleVariables[0];
                var rectangleHeight = decimal.Parse(rectangleVariables[1]);
                var rectangleWidth = decimal.Parse(rectangleVariables[2]);
                var rectangleX1 = decimal.Parse(rectangleVariables[3]);
                var rectangleY2 = decimal.Parse(rectangleVariables[4]);

                Rectangle currentRectangle = new Rectangle(rectangleID,rectangleWidth,rectangleHeight,rectangleX1,rectangleY2);
                rectangles.Add(currentRectangle);
            }

            for (int i = 0; i < numOfChecks; i++)
            {
                var checkEntries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var rectangleIDOne = checkEntries[0];
                var rectangleIDTw0 = checkEntries[1];

                Console.WriteLine((Rectangle.FindIntersaction(rectangles.FirstOrDefault(r => r.ID == rectangleIDOne),rectangles.FirstOrDefault(r => r.ID == rectangleIDTw0))).ToString().ToLower());




                }




        }
    }
}
