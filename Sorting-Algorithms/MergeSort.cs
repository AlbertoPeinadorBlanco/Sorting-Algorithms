using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public MergeSort(Panel _panel, int[] _numbers, Graphics _g) : base(_panel, _numbers, _g)
        {
            numbersArray = _numbers;
            g = _g;
            panel = _panel;
            pen = new Pen(Color.Red, 10);

        }
        public void sortingNumbers()
        {
            throw new NotImplementedException();
        }
    }
}
