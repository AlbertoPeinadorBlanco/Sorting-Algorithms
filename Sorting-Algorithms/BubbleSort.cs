using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class BubbleSort : drawingArray, ISorting
    {
        private bool _isSorted;
        private int[] numbersArray;
        private Graphics g;
        private Panel panel;
        private Pen pen;
        private PointF origin;


        public void sortingNumbers(Panel _panel, int[] array, Graphics gr)
        {
            pen = new Pen(Color.Red, 20);
            panel = _panel;
            numbersArray = array;
            g = gr;

            int length = numbersArray.Length - 1;

           


            for (int i = 0; i < length; i++)
            {
                _isSorted = isSorted();

                if (_isSorted)
                {
                    resetGraphics(1);


                    break;
                }



                for (int j = 0; j < length; j++)
                {

                    resetGraphics(j);


                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                    Thread.Sleep(1000);

                }
            }

            
   
        }

        private bool isSorted()
        {
            for(int i = 0; i < numbersArray.Length - 1; i++)
            {
                if (numbersArray[i] > numbersArray[i + 1])
                {
                    return false;
                }
            }
            return true;
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

            this.graphicsGenerator(panel, g, numbersArray);

            g.DrawEllipse(pen, xPosition - xPositionSize / 4 - numberSize + xPosition * j, panel.Height / 3 + numberSize * 2,
                xPositionSize * 2, xPositionSize * 2);
        }
    }
}
