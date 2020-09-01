using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public class StandartArgumentFactory : ArgumentsFactory
    {
        private IArgumentCreator creator;

        public StandartArgumentFactory(ITagGenerator tagGenerator) :base(tagGenerator) {  }

        public override IList CreateArgumnets(APIMethods type)
        {

            creator = new ArgumentCreator(); 

            //to do

            return creator.CreateArguments(type);
        }
    }
}