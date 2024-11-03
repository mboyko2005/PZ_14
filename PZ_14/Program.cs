namespace PZ_14
{
	class Program
	{
		static void Main(string[] args)
		{
			// Создание объекта фасада
			EmployeeFacade facade = new EmployeeFacade();

			// Добавление сотрудников
			facade.AddEmployee("Иван Иванов", "Менеджер", 70000, "9:00 - 18:00");
			facade.AddEmployee("Пётр Петров", "Разработчик", 90000, "10:00 - 19:00");

			// Показ информации о сотрудниках
			facade.ShowEmployeeDetails("Иван Иванов");
			facade.ShowEmployeeDetails("Пётр Петров");

			// Ожидание ввода пользователя, чтобы программа не закрывалась сразу
			Console.ReadLine();
		}
	}

}
