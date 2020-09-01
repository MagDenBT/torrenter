using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public class DataScheme : IDataScheme
    {
        private APIMethods[] APIMethods;
        private string Name;
        private Type ObType;
        private IDataScheme[] Childs;

        public DataScheme(string name, Type obType, params APIMethods[] APIMethods)
        {
            Name = name;
            ObType = obType;
            this.APIMethods = APIMethods;
        }
        public APIMethods[] GetAssignment()
        {
            return APIMethods;
        }

    

        public IDataScheme[] GetChilds()
        {
            return Childs;
        }

        public void PutChild(params IDataScheme[] childs) 
        {
            Childs = childs;
        }

        public string GetName()
        {
            return Name;
        }

        public Type GetObType()
        {
            return ObType;
        }



    }
}