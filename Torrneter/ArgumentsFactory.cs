using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    /// <summary>
    /// Контруирует готовый объект-аргумент для запросов
    /// </summary>
    public abstract class ArgumentsFactory
    {

        private ITagGenerator tagGenerator;

        public ArgumentsFactory(ITagGenerator TagGenerator)
        {
            tagGenerator = TagGenerator;
        }


        /// <summary></summary>
        public abstract Dictionary<String, IArgumentField<object>> CreateArgumnets(ArgumentType type);

    }
}