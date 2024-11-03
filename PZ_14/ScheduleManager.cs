using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14
{
	class ScheduleManager
	{
		// Метод для установки графика работы сотрудника
		public void SetSchedule(Employee employee, string schedule)
		{
			employee.WorkSchedule = schedule;
			Console.WriteLine($"График для {employee.Name} установлен: {schedule}");
		}

		// Метод для отображения графика работы сотрудника
		public void ShowSchedule(Employee employee)
		{
			Console.WriteLine($"График для {employee.Name}: {employee.WorkSchedule}");
		}
	}

}
