using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Torrneter.TempSketches
{
    interface Iterator<T>
    {
        bool HasNext();
        T Next();
        
    }
}
