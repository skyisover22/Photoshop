using System;
using System.Windows.Forms;
using MyPhotoshop.Filters;

namespace MyPhotoshop
{
	class MainClass
	{
        [STAThread]
		public static void Main (string[] args)
		{
			var window=new MainWindow();
			window.AddFilter (new PixelFilter<LighteningParameters>(
			    "����������/����������",
                (pixel, parameters)=>pixel*parameters.Cofficient
                ));

		    window.AddFilter(new PixelFilter<EmptyParameters>(
		        "������� ������",
		        (original, parameters) =>
		        {
		            var lightness = original.R + original.G + original.B;
		            lightness /= 3;
		            return new Pixel(lightness, lightness, lightness);
		        }
		        ));

            Application.Run (window);
		}
	}
}
