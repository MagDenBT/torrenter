using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torrneter.Arguments;

namespace Torrneter.TempSketches
{
    class ChildableTest : Iterator<CustomPair<string>>

    {
        private Stack<Iterator<CustomPair<string>>> stack = new Stack<Iterator<CustomPair<string>>>();

        public ChildableTest(Iterator<CustomPair<string>> iterator)
        {
            stack.Push(iterator);
        }
        public bool HasNext()
        {
            
        }

        public CustomPair<string> Next()
        {
            if (HasNext())
            {
                Iterator<CustomPair<string>> iterator = stack.Peek();
                CustomPair<string> pair = iterator.Next();


            }
        }
    }
}
