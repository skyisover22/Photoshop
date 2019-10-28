using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyPhotoshop.Filters;

namespace MyPhotoshop
{
    public abstract class ParametrisedFilter<TParameters> : IFilter
        where TParameters : IParameters, new ()
    {
        public ParameterInfo[] GetParameters() => new TParameters().GetDescription();

        public Photo Process(Photo original, double[] values)
        {
            var parameters = new TParameters();
            parameters.SetValues((values));
            return Process(original, parameters);
        }

        public abstract Photo Process(Photo original, TParameters parameters);
    }
}
