using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_14_2_
{
	interface IEmployeeDataAdapter
	{
		List<Employee> LoadData(string filePath);
	}

}
