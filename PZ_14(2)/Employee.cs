﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14_2_
{
	class Employee
	{
		public string Name { get; set; }
		public string Position { get; set; }
		public double Salary { get; set; }
		public string WorkSchedule { get; set; }

		public Employee(string name, string position, double salary, string workSchedule)
		{
			Name = name;
			Position = position;
			Salary = salary;
			WorkSchedule = workSchedule;
		}
	}

}