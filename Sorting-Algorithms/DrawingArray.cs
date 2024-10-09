using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sorting_Algorithms
{
    internal class drawingArray : IDrawingArray
    {
        private Graphics g;
        private Panel panel;
        private int[] numbers;

        public void graphicsGenerator(Panel _panel, Graphics _g, int[] _numbers)
        {

            numbers = _numbers;
            g = _g;
            panel = _panel;
            
            g = panel.CreateGraphics();

            Font font = new System.Drawing.Font(new FontFamily("Times New Roman"), 30);
            string number = "10";

            int numberSize = Convert.ToInt16(number);

            SizeF textSize = g.MeasureString(number, font);
            PointF origin;
            float xPositionSize = panel.Width / 11 - numberSize;
            float xPosition = xPositionSize;
            float yPosition = panel.Height / 2 - numberSize / 2;


            for (int i = 0; i < numbers.Length; i++)
            {
                origin = new PointF(xPosition, yPosition);

                g.DrawString(numbers[i].ToString(), font, Brushes.White, origin);

                xPosition = xPosition + xPositionSize;

            }

        }   
        
    }
}
