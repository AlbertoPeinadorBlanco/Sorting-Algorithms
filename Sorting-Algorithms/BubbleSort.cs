using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sorting_Algorithms
{
    internal class BubbleSort :  DrawingArray, ISorting
    {
        private bool _isSorted;
        private int[] numbersArray;
        private Graphics g;
        private Panel panel;
        private Pen pen;
        private PointF origin;
        private int time;

        public BubbleSort(Panel _panel, int[] _numbers, Graphics _g) : base(_panel, _numbers, _g)
        {
            panel = _panel;
            numbersArray = _numbers;
            g = _g;
            pen = new Pen(Color.Red, 10);

        } 

        public void sortingNumbers()
        {

            StaticValues.time = 1000;

            int length = numbersArray.Length - 1;


            for (int i = 0; i < length; i++)
            {
                  
                _isSorted = this.isSorted();

                if (_isSorted)
                {
                    resetGraphics(0);

                    break;
                }
                for (int j = 0; j < length; j++)
                {
                    
                    resetGraphics(j);


                    if (numbersArray[j] > numbersArray[j + 1])
                    {
                        int temp = numbersArray[j];
                        numbersArray[j] = numbersArray[j + 1];
                        numbersArray[j + 1] = temp;

                    }

                    time = StaticValues.time;

                    Thread.Sleep(time);

                }
            }

            
        }

        
        public void resetGraphics(int _j)
        {
            int numberSize = 10;
            int j = _j;
            

            float xPositionSize = panel.Width / 11 - numberSize;
            float xPosition = xPositionSize;
            float yPosition = panel.Height / 2 - numberSize / 2;

            origin = new PointF(xPosition, yPosition);

            g.Clear(Color.LightSlateGray);

            this.graphicsGenerator();

            g.DrawEllipse(pen, xPosition - xPositionSize / 4 - numberSize + xPosition * j, panel.Height / 3 + numberSize * 2,
                xPositionSize * 2, xPositionSize * 2);

        }

    }
}
