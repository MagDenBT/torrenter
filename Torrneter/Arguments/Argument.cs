using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public class Argument : IArgumentField
    {
        private string FieldName;

        private object Value;

        public Argument(string fieldName) { FieldName = fieldName; }


        public string GetFieldName()
        {
            return FieldName;
        }

        public T GetValue<T>()
        {
            return (T)Value;
        }

      

        public void PutValue<T>(T value)
        {
            Value = value;
        }
    }
}