﻿using MyPhotoshop.Filters;

namespace MyPhotoshop
{
    public class LighteningParameters : IParameters
    {
        public double Cofficient { get; set; }

        public ParameterInfo[] GetDescription()
        {
            return new[] { new ParameterInfo
                { Name="Коэффициент", MaxValue=10, MinValue=0, Increment=0.1, DefaultValue=1 }
            };
        }

        public void SetValues(double[] values)
        {
            Cofficient = values[0];
        }
    }
}