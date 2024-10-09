using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class BubbleSortInjector
    {
        private readonly ISorting iBubbleSort;

        public BubbleSortInjector(ISorting _iBubbleSort)
        {
            iBubbleSort = _iBubbleSort;
        }

        public void numbersSorting(int[] array, Graphics g)
        {
            iBubbleSort.sortingNumbers(array, g);
        }

    }
}
