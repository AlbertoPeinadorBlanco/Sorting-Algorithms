using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class DrawingArray : IDrawingArray, INextStep, ISwap, IisSorted
    {
        private Graphics g;
        private Panel panel;
        private int[] numbers;

        public DrawingArray(Panel _panel, int[] _numbers, Graphics _g)
        {
            panel = _panel;
            numbers = _numbers;
            g = _g;
        }

        public void graphicsGenerator()
        {
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

        public bool isSorted()
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public void NextSteep()
        {
            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Swap(i, i + 1);
                }
            }
        }

        public void Swap(int i, int p)
        {
            int temp = numbers[i];
            numbers[i] = numbers[i + 1];
            numbers[i + 1] = temp;
        }
    }
}
