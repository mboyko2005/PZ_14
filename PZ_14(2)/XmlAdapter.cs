using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace PZ_14_2_
{
	class XmlAdapter : IEmployeeDataAdapter
	{
		public List<Employee> LoadData(string filePath)
		{
			var employees = new List<Employee>();
			var doc = XDocument.Load(filePath);

			Console.WriteLine($"Загрузка данных из XML файла: {filePath}");
			foreach (var element in doc.Descendants("Employee"))
			{
				var name = element.Element("Name")?.Value;
				var position = element.Element("Position")?.Value;
				var salary = double.Parse(element.Element("Salary")?.Value ?? "0");
				var schedule = element.Element("WorkSchedule")?.Value;

				if (name != null && position != null && schedule != null)
				{
					var employee = new Employee(name, position, salary, schedule);
					employees.Add(employee);
					Console.WriteLine($"Загружен сотрудник: {employee.Name}, {employee.Position}, {employee.Salary}, {employee.WorkSchedule}");
				}
			}

			Console.WriteLine($"Всего загружено {employees.Count} сотрудников из XML файла.\n");
			return employees;
		}
	}
}

