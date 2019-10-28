using System;

namespace MyPhotoshop
{
	public interface IFilter
	{
        /// Этот метод должен возвращать описание параметров, которые появляются в NumericUpDown-контроле
        /// снизу от контрола выбора фильтра
        ParameterInfo[] GetParameters();
        
	    /// Этот метод принимает фотографию, которую надо обрабатывать, и численные значения всех параметров
        /// Длина массива parameters в точности равна длине массива, возвращаемого методом GetParameters
        Photo Process(Photo original, double[] parameters);
	}
}