using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PZ_14_2_
{
	class EncodingAdapter : IEmployeeDataAdapter
	{
		public List<Employee> LoadData(string filePath)
		{
			var employees = new List<Employee>();

			// Прочитать файл с перекодировкой из Windows-1251 (или другой кодировки) в UTF-8
			byte[] fileBytes = File.ReadAllBytes(filePath);
			string fileContent = Encoding.UTF8.GetString(fileBytes);

			// Разделяем строки по новой строке
			var lines = fileContent.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

			Console.WriteLine($"Загрузка данных из файла с перекодировкой: {filePath}");
			foreach (var line in lines)
			{
				var parts = line.Split(new[] { ';', ',' }); // Поддержка обоих разделителей
				if (parts.Length == 4)
				{
					var employee = new Employee(parts[0].Trim(), parts[1].Trim(), double.Parse(parts[2]), parts[3].Trim());
					employees.Add(employee);
					Console.WriteLine($"Загружен сотрудник: {employee.Name}, {employee.Position}, {employee.Salary}, {employee.WorkSchedule}");
				}
			}

			Console.WriteLine($"Всего загружено {employees.Count} сотрудников из файла с перекодировкой.\n");
			return employees;
		}
	}
}
