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
int ReadInt(string arg)
{
	Console.Write($"Введите {arg}: ");
	int num;

	while (!int.TryParse(Console.ReadLine(), out num))
	{
		Console.Write("Значение не подходит, повторите: ");
	}

	return num;
}

void PrintFromNToOneRecursion(int n)
{
	if (n > 0)
	{
		Console.Write($"{n} ");
		PrintFromNToOneRecursion(--n);
	}
}

bool CheckPositive(int n)
{
	if (n > 0) return true;
	else return false;
}

int CalculateSumOfNaturalFromMToNRecursion(int m, int n)
{
	if (m > 0)
	{
		return m + CalculateSumOfNaturalFromMToNRecursion(m - 1, n);
	}

	return 0;
}

bool CheckNumbers(int m, int n)
{
	if (m < 1 || n < 1)
	{
		return false;
	}

	return true;
}

int CalculateAckermanRecursion(int m, int n)
{
	if (m == 0)
	{
		return n + 1;
	}
	else if (m > 0 && n == 0)
	{
		return CalculateAckermanRecursion(m - 1, 1);
	}
	else if (m > 0 && n > 0)
	{
		return CalculateAckermanRecursion(m - 1, CalculateAckermanRecursion(m, n - 1));
	}

	return 0;
}

void Task_1()
{
	// Здесь вызываем необходимые методы для выполнения 1-й задачи
	int n = ReadInt("число N");

	if (CheckPositive(n))
	{
		PrintFromNToOneRecursion(n);
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
	int n1 = ReadInt("число М");
	int n2 = ReadInt("число N");
	int sum = 0;

	if (n1 == n2)
	{
		Console.WriteLine("Числа равны");
	}
	else if (CheckNumbers(n1, n2))
	{
		if (n1 > n2)
		{
			sum = CalculateSumOfNaturalFromMToNRecursion(n1, n2);
			Console.WriteLine($"Сумма всех элементов от {n1} до {n2} равна {sum}");
		}
		else if (n2 > n1)
		{
			sum = CalculateSumOfNaturalFromMToNRecursion(n2, n1);
			Console.WriteLine($"Сумма всех элементов от {n2} до {n1} равна {sum}");
		}
	}
}

void Task_3()
{
	// Здесь вызываем необходимые методы для выполнения 3-й задачи
	int n1 = ReadInt("число М");
	int n2 = ReadInt("число N");
	int result = CalculateAckermanRecursion(n1, n2);
	Console.WriteLine($"A({n1}, {n2}) = {result}");
}

TaskMenu();