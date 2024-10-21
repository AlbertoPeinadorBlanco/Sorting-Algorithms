using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sorting_Algorithms
{
    internal class MergeSort : DrawingArray, ISorting
    {
        private bool _isSorted;
        private int[] numbersArray;
        private Graphics g;
        private Panel panel;
        private Pen pen;
        private PointF origin;
        private int left;
        private int right;
        private int time;


        public MergeSort(Panel _panel, int[] _numbers, Graphics _g) : base(_panel, _numbers, _g)
        {
            numbersArray = _numbers;
            g = _g;
            panel = _panel;
            pen = new Pen(Color.Red, 10);
            time = StaticValues.time = 1000;

        }


        public void sortingNumbers()
        {
            sortArray(numbersArray, 0, numbersArray.Length - 1);

        }

        public void resetGraphics(int _i, int _j, int[] _right, int[] _left)
        {
            int i = _i;
            int j = _j;
            int[] right = _right;
            int[] left = _left;
            int numberSize = 10;
            Font font = new System.Drawing.Font(new FontFamily("Times New Roman"), 30);


            float xPositionSize = panel.Width / 11 - numberSize;
            float xPosition = xPositionSize;
            float yPosition = panel.Height / 2 - numberSize / 2;


            g.Clear(Color.LightSlateGray);

            for (i = 0; i < left.Length; i++)
            {
                origin = new PointF(xPosition, yPosition);

                g.DrawString(left[i].ToString(), font, Brushes.White, origin);

                xPosition = xPosition + xPositionSize;

            }

            this.graphicsGenerator();
        }

       
        public int[] sortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                sortArray(array, left, middle);
                sortArray(array, middle + 1, right);
                mergeArray(array, left, middle, right);
            }
            return array;
        }
        public void mergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;

            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];

            int i, j;


            
                
            for(i = 0; i < leftArrayLength; ++i)
            {
                leftTempArray[i] = array[left + i];

            }

            for (j = 0; j < rightArrayLength; ++j)
            {
                rightTempArray[j] = array[middle + 1 + j];

            }
                

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];

                }
                else
                {
                    array[k++] = rightTempArray[j++];

                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];

            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];

            }
            time = StaticValues.time;

            Thread.Sleep(time);

            g.Clear(Color.LightSlateGray);

            this.graphicsGenerator();

        }
    }
}
