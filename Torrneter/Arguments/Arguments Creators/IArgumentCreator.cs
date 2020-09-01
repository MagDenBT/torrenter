using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public interface IArgumentCreator
    {
        IList CreateArguments(APIMethods type);
    }
}