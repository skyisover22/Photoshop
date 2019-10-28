﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyPhotoshop.Filters;

namespace MyPhotoshop
{
    public class PixelFilter<TParameters> : ParametrisedFilter<TParameters>
        where TParameters : IParameters, new()
    {
        string name;
        Func<Pixel, TParameters, Pixel> processor;

        public PixelFilter(string name, Func<Pixel, TParameters, Pixel> processor)
        {
            this.name = name;
            this.processor = processor;
        }

        public override Photo Process(Photo original, TParameters parameters)
        {
            var result = new Photo(original.width, original.height);

            for (int x = 0; x < result.width; x++)
            for (int y = 0; y < result.height; y++)
            {
                result[x, y] = processor(original[x, y], parameters);
            }
            return result;
        }

        public override string ToString() => name;
    }
}
