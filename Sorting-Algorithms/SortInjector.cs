using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class SortInjector
    {
        private readonly ISorting sorting;
        public SortInjector(ISorting sort)
        {
            sorting = sort;
        }

        public void numbersSorting()
        {
            sorting.sortingNumbers(); 
        }

    }
}
