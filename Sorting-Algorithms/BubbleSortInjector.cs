using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class BubbleSortInjector
    {
        private readonly ISorting sorting;
        public BubbleSortInjector(ISorting _iBubbleSort)
        {
            sorting = _iBubbleSort;
        }

        public void numbersSorting(Panel panel, int[] array, Graphics g)
        {
            sorting.sortingNumbers(panel, array, g); 
        }

    }
}
