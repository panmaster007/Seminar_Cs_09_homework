void TaskMenu()
{
	bool exitOut = true;

	while (exitOut == true)
	{
		Console.WriteLine("Введите номер задачи(1, 2, 3 либо q/Q для выхода):");
		string selectTask = "";
		selectTask = Console.ReadLine();

		switch (selectTask)
		{
			case "1":
				{
					Console.Clear();
					Task_1();
					break;
				}

			case "2":
				{
					Console.Clear();
					Task_2();
					break;
				}

			case "3":
				{
					Console.Clear();
					Task_3();
					break;
				}
			case "q":
				{
					exitOut = false;
					Console.Clear();
					break;
				}

			case "Q":
				{
					exitOut = false;
					Console.Clear();
					break;
				}

			default:
				{
					Console.WriteLine("Вы не попали в нужную кнопку, попробуйте ещё раз!");
					break;
				}
		}
	}
}

// здесь располагаем методы для выполнения задач

void Task_1()
{
	// Здесь вызываем необходимые методы для выполнения 1-й задачи
}

void Task_2()
{
	// Здесь вызываем необходимые методы для выполнения 2-й задачи
}

void Task_3()
{
	// Здесь вызываем необходимые методы для выполнения 3-й задачи
}
TaskMenu();