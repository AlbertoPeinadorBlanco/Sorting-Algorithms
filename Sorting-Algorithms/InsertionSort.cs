using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sorting_Algorithms
{
    internal class InsertionSort : DrawingArray, ISorting
    {

        private bool _isSorted;
        private int[] numbersArray;
        private Graphics g;
        private Panel panel;
        private Pen pen;
        private PointF origin;
        private int time;

        public InsertionSort(Panel _panel, int[] _numbers, Graphics _g) : base(_panel, _numbers, _g)
        {
            panel = _panel;
            numbersArray = _numbers;
            g = _g;
            pen = new Pen(Color.Red, 10);
            time = StaticValues.time = 1000;
        }

        public void sortingNumbers()
        {

            int n = numbersArray.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = numbersArray[i];
                int j = i - 1;
                

                while (j >= 0 && numbersArray[j] > key)
                {
                   numbersArray[j + 1] = numbersArray[j];
                    j = j - 1;

                    
                }

                time = StaticValues.time;

                Thread.Sleep(time);

                g.Clear(Color.LightSlateGray);

                this.graphicsGenerator();

                numbersArray[j + 1] = key;


            }
        }

  
    }
}
