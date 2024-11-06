using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14_3_
{
	class BestEmployeeAward : EmployeeDecorator
	{
		public BestEmployeeAward(IEmployee employee) : base(employee) { }

		public override string GetDetails()
		{
			return $"{employee.GetDetails()} - Награда: Лучший работник месяца";
		}

		public override double GetSalary()
		{
			return employee.GetSalary() + 5000; // Доплата за награду
		}
	}

}
