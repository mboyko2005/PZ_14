using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14_3_
{
	
	abstract class EmployeeDecorator : IEmployee
	{
		protected IEmployee employee;

		public EmployeeDecorator(IEmployee employee)
		{
			this.employee = employee;
		}

		public virtual string GetDetails()
		{
			return employee.GetDetails();
		}

		public virtual double GetSalary()
		{
			return employee.GetSalary();
		}
	}

}
