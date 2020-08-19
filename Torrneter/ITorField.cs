using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public interface IArgumentField<T>
    {
        string GetFieldName();
        T GetValue();
        void PutValue(T value);
    }
}