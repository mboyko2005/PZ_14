using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14
{
	class SalaryCalculator
	{
		// Метод для расчёта и отображения зарплаты сотрудника
		public void CalculateSalary(Employee employee)
		{
			Console.WriteLine($"Зарплата для {employee.Name}: {employee.Salary} руб.");
		}
	}

}
