using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_14_2_
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

			// Загрузка данных из TXT файла с исправленной кодировкой
			IEmployeeDataAdapter txtAdapter = new TxtAdapter();
			List<Employee> txtEmployees = txtAdapter.LoadData("employees.txt");

			// Загрузка данных из CSV файла с исправленной кодировкой
			IEmployeeDataAdapter csvAdapter = new CsvAdapter();
			List<Employee> csvEmployees = csvAdapter.LoadData("employees.csv");

			// Загрузка данных из XML файла без изменений
			IEmployeeDataAdapter xmlAdapter = new XmlAdapter();
			List<Employee> xmlEmployees = xmlAdapter.LoadData("employees.xml");

			Console.WriteLine($"Всего загружено сотрудников: {txtEmployees.Count + csvEmployees.Count + xmlEmployees.Count}");

			Console.ReadLine();
		}
	}
}
