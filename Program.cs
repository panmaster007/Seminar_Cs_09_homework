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
int ReadInteger(string arg)
{
	Console.Write($"Введите {arg}: ");
	int num;

	while (!int.TryParse(Console.ReadLine(), out num))
	{
		Console.Write("Значение не подходит, повторите: ");
	}

	return num;
}

void PrintRecursion(int n)
{
	if (n > 0)
	{
		Console.Write($"{n} ");
		PrintRecursion(--n);
	}
}

bool CheckPositive(int n)
{
	if (n > 0) return true;
	else return false;
}

int CalculateSum(int m, int n)
{
	if (m > 0)
	{
		return m + CalculateSum(m - 1, n);
	}

	return 0;
}

bool CheckNumber(int m, int n)
{
	if (m < 1 || n < 1)
	{
		return false;
	}

	return true;
}

int CalculateAkerman(int m, int n)
{
	if (m == 0)
	{
		return n + 1;
	}
	else if (m > 0 && n == 0)
	{
		return CalculateAkerman(m - 1, 1);
	}
	else if (m > 0 && n > 0)
	{
		return CalculateAkerman(m - 1, CalculateAkerman(m, n - 1));
	}

	return 0;
}

void Task_1()
{
	// Здесь вызываем необходимые методы для выполнения 1-й задачи
	int n = ReadInteger("число N");

	if (CheckPositive(n))
	{
		PrintRecursion(n);
		Console.WriteLine();
	}
	else
	{
		Console.WriteLine("Число меньше 1");
	}
}

void Task_2()
{
	// Здесь вызываем необходимые методы для выполнения 2-й задачи
	int n1 = ReadInteger("число М");
	int n2 = ReadInteger("число N");
	int sum = 0;

	if (n1 == n2)
	{
		Console.WriteLine("Числа равны");
	}
	else if (CheckNumber(n1, n2))
	{
		if (n1 > n2)
		{
			sum = CalculateSum(n1, n2);
			Console.WriteLine($"Сумма всех элементов от {n1} до {n2} равна {sum}");
		}
		else if (n2 > n1)
		{
			sum = CalculateSum(n2, n1);
			Console.WriteLine($"Сумма всех элементов от {n2} до {n1} равна {sum}");
		}
	}
}

void Task_3()
{
	// Здесь вызываем необходимые методы для выполнения 3-й задачи
	int n1 = ReadInteger("Введите число М");
	int n2 = ReadInteger("Введите число N");
	int result = CalculateAkerman(n1, n2);
	Console.WriteLine($"A({n1}, {n2}) = {result}");
}

TaskMenu();