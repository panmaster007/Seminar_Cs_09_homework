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
	Console.Write($"{arg}: ");
	int num;

	while (!int.TryParse(Console.ReadLine(), out num))
	{
		Console.Write("Error, repeat again: ");
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

bool CheckPos(int n)
{
	if (n > 0) return true;
	else return false;
}

int SumNamber(int m, int n)
{
	if (m > n - 1)
	{
		return m + SumNamber(m - 1, n);
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
	int n = ReadInteger("Введите число N");

	if (CheckPos(n))
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
	int m = ReadInteger("Введите число М");
	int n = ReadInteger("Введите число N");
	int sum = 0;

	if (m == n)
	{
		Console.WriteLine("Числа равны");
	}
	else if (CheckNumber(m, n))
	{
		if (m > n)
		{
			sum = SumNamber(m, n);
			Console.WriteLine($"Сумма элементов от {m} до {n} равна {sum}");
		}
		else if (n > m)
		{
			sum = SumNamber(n, m);
			Console.WriteLine($"Сумма элементов от {n} до {m} равна {sum}");
		}
	}
}

void Task_3()
{
	// Здесь вызываем необходимые методы для выполнения 3-й задачи
	int m = ReadInteger("Введите число М");
	int n = ReadInteger("Введите число N");
	int result = CalculateAkerman(m, n);
	Console.WriteLine($"A({m}, {n}) = {result}");
}

TaskMenu();