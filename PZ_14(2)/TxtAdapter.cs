using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PZ_14_2_
{
	class TxtAdapter : IEmployeeDataAdapter
	{
		public List<Employee> LoadData(string filePath)
		{
			var employees = new List<Employee>();

			// Регистрируем поставщика кодировок и используем Windows-1251
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
			var lines = File.ReadAllLines(filePath, Encoding.GetEncoding("windows-1251"));

			Console.WriteLine($"Загрузка данных из TXT файла: {filePath}");
			foreach (var line in lines)
			{
				var parts = line.Split(';');
				if (parts.Length == 4)
				{
					var employee = new Employee(parts[0].Trim(), parts[1].Trim(), double.Parse(parts[2]), parts[3].Trim());
					employees.Add(employee);
					Console.WriteLine($"Загружен сотрудник: {employee.Name}, {employee.Position}, {employee.Salary}, {employee.WorkSchedule}");
				}
			}

			Console.WriteLine($"Всего загружено {employees.Count} сотрудников из TXT файла.\n");
			return employees;
		}
	}
}
