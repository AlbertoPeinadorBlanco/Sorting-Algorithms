using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            time = StaticValues.time;
        }

        public void sortingNumbers()
        {


        }
    }
}
