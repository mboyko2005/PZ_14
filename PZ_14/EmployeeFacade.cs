using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14
{
	class EmployeeFacade
	{
		private EmployeeData employeeData = new EmployeeData();
		private ScheduleManager scheduleManager = new ScheduleManager();
		private SalaryCalculator salaryCalculator = new SalaryCalculator();

		// Метод для добавления сотрудника
		public void AddEmployee(string name, string position, double salary, string schedule)
		{
			var employee = new Employee(name, position, salary, schedule);
			employeeData.AddEmployee(employee);
			scheduleManager.SetSchedule(employee, schedule);
		}

		// Метод для отображения информации о сотруднике
		public void ShowEmployeeDetails(string name)
		{
			var employee = employeeData.GetEmployee(name);
			if (employee != null)
			{
				Console.WriteLine($"\nИмя: {employee.Name}");
				Console.WriteLine($"Должность: {employee.Position}");
				Console.WriteLine($"Зарплата: {employee.Salary}");
				scheduleManager.ShowSchedule(employee);
				salaryCalculator.CalculateSalary(employee);
			}
			else
			{
				Console.WriteLine($"\nСотрудник с именем {name} не найден.");
			}
		}
	}

}
