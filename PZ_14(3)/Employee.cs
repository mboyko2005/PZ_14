using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14_3_
{
	
	class Employee : IEmployee
	{
		private string name;
		private string position;
		private double salary;

		public Employee(string name, string position, double salary)
		{
			this.name = name;
			this.position = position;
			this.salary = salary;
		}

		public string GetDetails()
		{
			return $"{name} - {position} - Зарплата: {salary}";
		}

		public double GetSalary()
		{
			return salary;
		}
	}

}
