using System;

namespace MyPhotoshop
{
	public interface IFilter
	{
        /// ���� ����� ������ ���������� �������� ����������, ������� ���������� � NumericUpDown-��������
        /// ����� �� �������� ������ �������
        ParameterInfo[] GetParameters();
        
	    /// ���� ����� ��������� ����������, ������� ���� ������������, � ��������� �������� ���� ����������
        /// ����� ������� parameters � �������� ����� ����� �������, ������������� ������� GetParameters
        Photo Process(Photo original, double[] parameters);
	}
}