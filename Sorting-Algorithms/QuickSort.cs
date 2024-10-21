using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class QuickSort : DrawingArray, ISorting
    {

        private bool _isSorted;
        private int[] numbersArray;
        private Graphics g;
        private Panel panel;
        private Pen pen;
        private PointF origin;
        private int time;

        public QuickSort(Panel _panel, int[] _numbers, Graphics _g) : base (_panel, _numbers, _g)
        {
            panel = _panel;
            numbersArray = _numbers;
            g = _g;
            pen = new Pen(Color.Red, 10);
            time = StaticValues.time = 1000;

        }
        public void sortingNumbers()
        {
            quickSort(numbersArray, 0, numbersArray.Length - 1);

            g.Clear(Color.LightSlateGray);

            this.graphicsGenerator();
        }

        static int Partition(int[] arr, int low, int high)
        {

            int pivot = arr[high];


            int i = low - 1;

            
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }

            }

           
            Swap(arr, i + 1, high);
            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                int pi = Partition(arr, low, high);

                
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

    }
}
