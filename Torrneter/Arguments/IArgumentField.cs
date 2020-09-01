using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public interface IArgumentField
    {
        string GetFieldName();
        T GetValue<T>();
        void PutValue<T>(T value);
    }
}