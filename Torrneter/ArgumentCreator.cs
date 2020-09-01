using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Documents;

namespace Torrneter
{
    public class ArgumentCreator : IArgumentCreator
    {
        public IList CreateArguments(APIMethods type)
        {
            APIContainer container = APIArgumentsContainer.GetInstance();
            IList<IDataScheme> schemes = SetFilter(container.GetList(), type);
            IList<Argument> arguments = ObjectAssembling(schemes);

        }

        private IList<Argument> ObjectAssembling(IList<IDataScheme> schemes)
        {
            IList<Argument> arguments = new List<Argument>();

            foreach(IDataScheme scheme in schemes)
            {
                object ob = null;
                var cOb = Convert.ChangeType(ob, scheme.GetObType());
                Argument a = new Argument(scheme.GetName());
               
                a.PutValue(cOb);

            }


            return arguments;

        }

        private IList<IDataScheme> SetFilter(IList<IDataScheme> schemes, APIMethods type)
        {
            IList<IDataScheme> filteredSchemes = new List<IDataScheme>();

            foreach (IDataScheme scheme in schemes)
            {
                if ((scheme.GetAssignment()).Contains(type))
                    filteredSchemes.Add(scheme);
            }
            return filteredSchemes;
        }
    }
}