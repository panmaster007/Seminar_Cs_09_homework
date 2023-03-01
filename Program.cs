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
 public int ReadInt(string arg)
  {
    Console.Write($"Введите {arg}: ");
    int num;

    while (!int.TryParse(Console.ReadLine(), out num))
    {
      Console.Write("Значение не подходит, повторите: ");
    }

    return num;
  }

  public void PrintFromNToOneRecursion(int n)
  {
    if (n > 0)
    {
      Console.Write($"{n} ");
      PrintFromNToOneRecursion(--n);
    }
  }

  public bool CheckPositive(int n)
  {
    if (n > 0) return true;
    else return false;
  }

  public int CalculateSumOfNaturalFromMToNRecursion(int m, int n)
  {
    if (m > 0)
    {
      return m + CalculateSumOfNaturalFromMToNRecursion(m - 1, n);
    }

    return 0;
  }

  public bool CheckNumbers(int m, int n)
  {
    if (m < 1 || n < 1)
    {
      return false;
    }

    return true;
  }

  public int CalculateAckermanRecursion(int m, int n)
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

	string text = $"Вы выбрали задачу номер 1{Environment.NewLine}"
					+ $"Вывести все натуральные числа от N до 1.{Environment.NewLine}";
	Console.WriteLine(text);

	int n = m.ReadInt("число N");

	if (m.CheckPositive(n))
	{
		m.PrintFromNToOneRecursion(n);
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
	string text = $"Вы выбрали задачу номер 2{Environment.NewLine}"
					 + $"Вывести сумму всех натуральных элементов в промежутке от M до N.{Environment.NewLine}";
	Console.WriteLine(text);

	int n1 = m.ReadInt("число М");
	int n2 = m.ReadInt("число N");
	int sum = 0;

	if (n1 == n2)
	{
		Console.WriteLine("Числа равны");
	}
	else if (m.CheckNumbers(n1, n2))
	{
		if (n1 > n2)
		{
			sum = m.CalculateSumOfNaturalFromMToNRecursion(n1, n2);
			Console.WriteLine($"Сумма всех элементов от {n1} до {n2} равна {sum}");
		}
		else if (n2 > n1)
		{
			sum = m.CalculateSumOfNaturalFromMToNRecursion(n2, n1);
			Console.WriteLine($"Сумма всех элементов от {n2} до {n1} равна {sum}");
		}
	}
}

void Task_3()
{
	// Здесь вызываем необходимые методы для выполнения 3-й задачи
	string text = $"Вы выбрали задачу номер 3{Environment.NewLine}"
				+ $"Вычисление функции Аккермана.{Environment.NewLine}";
	Console.WriteLine(text);

	int n1 = m.ReadInt("число М");
	int n2 = m.ReadInt("число N");
	int result = m.CalculateAckermanRecursion(n1, n2);

	Console.WriteLine($"A({n1}, {n2}) = {result}");
}
}
TaskMenu();