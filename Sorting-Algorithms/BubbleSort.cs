using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class BubbleSort : IBubbleSort
    {

        public int[] sortingBubble(int[] numbers)
        {
            int length = numbers.Length;

            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j < length; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j + 1] = temp;

                    }
                }
            }

            return numbers;

        }
    }
}
