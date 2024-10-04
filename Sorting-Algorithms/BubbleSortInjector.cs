using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class BubbleSortInjector
    {
        private readonly IBubbleSort iBubbleSort;

        public BubbleSortInjector(IBubbleSort _iBubbleSort)
        {
            iBubbleSort = _iBubbleSort;
        }

        public int[] bubbleSorting(int[] numbers)
        {
            return iBubbleSort.sortingBubble(numbers);
        }

    }
}
