﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public interface IParametersFactory<TParameters>
        where TParameters : IParameters
    {
        ParameterInfo[] GetDescription();
        TParameters CreateParameters(double[] values);
    }
}
