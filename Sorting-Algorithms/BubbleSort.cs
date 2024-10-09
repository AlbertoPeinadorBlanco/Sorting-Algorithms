using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class BubbleSort : ISorting
    {
        private bool _isSorted;
        private int[] numbersArray;
        private Graphics g;
        private Pen pen = new Pen(Color.Red, 10);

        public void sortingNumbers(int[] array, Graphics gr)
        {
            numbersArray = array;
            g = gr;
            int length = numbersArray.Length;


            while (!_isSorted)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;

                        }
                    }

                }

                _isSorted = isSorted();
            }

           
        }

        private bool isSorted()
        {
            for(int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > numbersArray[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
