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

        public void generatorGraphics(Panel _panel, Graphics _g, int[] _numbers)
        {
            iDrawingArray.graphicsGenerator(_panel, _g, _numbers);
        }
    }
}
