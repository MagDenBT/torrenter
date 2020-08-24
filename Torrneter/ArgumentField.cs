using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public interface IArgumentField
    {
        string GetFieldName();
        object GetValue();
        Type GetValueType();
        void PutValue(object value);
    }
}