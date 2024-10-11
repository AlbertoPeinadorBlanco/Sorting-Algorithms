using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class DrawingArrayInjector
    {
        private readonly IDrawingArray iDrawingArray;

        public DrawingArrayInjector(IDrawingArray _iDrawingArray)
        {
            iDrawingArray = _iDrawingArray;
        }

        public void generatorGraphics()
        {
            iDrawingArray.graphicsGenerator();
        }
    }
}
