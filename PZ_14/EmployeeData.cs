using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14
{

	class EmployeeData
	{
		private List<Employee> employees = new List<Employee>();

		
		public void AddEmployee(Employee employee)
		{
			employees.Add(employee);
			Console.WriteLine($"Сотрудник {employee.Name} успешно добавлен.");
		}


		public Employee GetEmployee(string name)
		{
			return employees.Find(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
		}


		public List<Employee> GetAllEmployees()
		{
			return employees;
		}
	}

}
