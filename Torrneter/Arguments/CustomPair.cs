using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torrneter.Arguments
{
    class CustomPair<TValue >
    {
        public string Alias { get; }
        public TValue Value { get; set; }

        public CustomPair(string alias, TValue value)
        {
            Alias = alias;
            Value = value;
        }

        public CustomPair(string alias)
        {
            Alias = alias;
        }

       
     
    }
}
