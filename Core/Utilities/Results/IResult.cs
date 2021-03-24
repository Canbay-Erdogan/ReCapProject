﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool success { get; }
        string Message { get; }
    }
}
