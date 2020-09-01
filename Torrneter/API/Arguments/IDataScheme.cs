using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public interface IDataScheme
    {
        string GetName();
        Type GetObType();
        APIMethods[] GetAssignment();
        IDataScheme[] GetChilds(); 
    }
}