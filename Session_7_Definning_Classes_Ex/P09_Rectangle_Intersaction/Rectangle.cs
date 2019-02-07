using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace DefiningClasses
{
    public class Rectangle
    {
        private string id;
        private decimal width;
        private decimal height;
        private decimal x1;
        private decimal y2;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public decimal Width
        {
            get { return this.width; }
            set { this.width = value; }
        }





        public decimal Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public decimal X1
        {
            get { return this.x1; }
            set { this.x1 = value; }
        }

        public decimal Y2
        {
            get { return this.y2; }
            set { this.y2 = value; }
        }

        public Rectangle(string newId, decimal newWidth, decimal newHeight, decimal newX1, decimal newY2)
        {
            this.ID = newId;
            this.Width = newWidth;
            this.Height = newHeight;
            this.X1 = newX1;
            this.Y2 = newY2;
        }

        public static bool FindIntersaction(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            var firstX1 = Math.Min((firstRectangle.X1), (firstRectangle.X1 + firstRectangle.Width));
            var firstX2 = Math.Max(firstX1, (firstRectangle.X1 + firstRectangle.Width));

            var firstY2 = Math.Max((firstRectangle.Y2), (firstRectangle.Y2 - firstRectangle.Height));
            var firstY1 = Math.Min(firstY2, (firstRectangle.Y2 - firstRectangle.Height));
            
            var secondX1 = Math.Min((secondRectangle.X1), (secondRectangle.X1 + secondRectangle.Width));
            var secondX2 = Math.Max(secondX1, secondRectangle.X1 + secondRectangle.Width);

            var secondY2 = Math.Max((secondRectangle.Y2), secondRectangle.Y2 - secondRectangle.height);
            var secondY1 = Math.Min(secondY2, (secondRectangle.Y2 - secondRectangle.height));

            if ((secondX2 >= firstX1 && secondX1 <= firstX2) && (secondY2 >= firstY1 && secondY1 <= firstY2))
            {
                return true;
            }
            return false;
        }
    }
}
