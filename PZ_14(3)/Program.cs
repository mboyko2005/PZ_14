namespace PZ_14_3_
{
	class Program
	{
		static void Main(string[] args)
		{
			// Создание базового сотрудника
			IEmployee employee1 = new Employee("Иван Иванов", "Менеджер", 70000);
			IEmployee employee2 = new Employee("Пётр Петров", "Разработчик", 90000);

			// Добавление декораторов (награды и сертификаты)
			employee1 = new BestEmployeeAward(employee1);
			employee2 = new AchievementCertificate(employee2);

			// Вывод информации о сотрудниках
			Console.WriteLine(employee1.GetDetails());
			Console.WriteLine($"Итоговая зарплата: {employee1.GetSalary()}\n");

			Console.WriteLine(employee2.GetDetails());
			Console.WriteLine($"Итоговая зарплата: {employee2.GetSalary()}");

			Console.ReadLine();
		}
	}

}
