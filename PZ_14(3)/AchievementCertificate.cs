using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14_3_
{
	class AchievementCertificate : EmployeeDecorator
	{
		public AchievementCertificate(IEmployee employee) : base(employee) { }

		public override string GetDetails()
		{
			return $"{employee.GetDetails()} - Сертификат за достижение";
		}

		public override double GetSalary()
		{
			return employee.GetSalary() + 3000; // Доплата за сертификат
		}
	}

}
