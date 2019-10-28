using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Filters
{
    public class TransformFilter : ParametrisedFilter<EmptyParameters>
    {
        Func<Size, Size> sizeTransform;
        Func<Pixel, Size, Pixel> pointTransform;
        string name;

        public override Photo Process(Photo original, EmptyParameters parameters)
        {
            var oldSize = new Size(original.width, original.height);
            var newSize = sizeTransform(oldSize);
            var result = new Photo(newSize.Width, newSize.Height);
            for (int x=0; x < newSize.Height; x++)
        }

        public override string ToString() => name;
    }
}
