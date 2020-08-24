﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torrneter
{
    public interface IArgumentCreator
    {
        Dictionary<string, ArgumentField<object>> CreateArguments();
    }
}