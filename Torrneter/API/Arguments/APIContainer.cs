using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public abstract class APIContainer
    {
        public abstract IList<IDataScheme> GetList();  
        
    }
}