while (true)
{
    Console.WriteLine("1) Показать двумерный массив заполненный вещественными числами;");
    Console.WriteLine("2) Задать двумерный массив правилом: Amn = m + n;");
    Console.WriteLine("3) Заменить в двумерном массиве элементы, у которых оба индекса четные на их квадраты;");
    Console.WriteLine("4) Программа для замены элементов первой и последней строки;");
    Console.WriteLine("0) Завершить работу");
    int task = ReadInt("Выберите задачу: ");
    if (task == 1)
        FirstTask();
    if (task == 2)
        SecondTask();
    if (task == 3)
        ThirdTask();
    if (task == 4)
        FourthTask();
    if (task == 0)
        break;
    void FirstTask()
    {//Задача 1 (Показать двумерный массив заполненный вещественными числами)
        int m = ReadInt("Введите колличество столбцов ");
        int n = ReadInt("Введите колличество строк ");

        float[,] array = new float[m, n];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(-10, 10) + Convert.ToSingle(new Random().NextDouble());
                array[i,j] = Convert.ToSingle(Math.Round(array[i,j],3));
            }
        }
        PrintArray(array);

        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void SecondTask()
    {//Задача 2 (Задать двумерный массив правилом: Amn = m + n)

        int m = ReadInt("Введите колличество столбцов ");
        int n = ReadInt("Введите колличество строк ");

        int[,] array = new int[m, n];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = i + j;
            }
        }
        PrintArray(array);

        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }

    void ThirdTask()
    {//Задача 3 (Заменить в двумерном массиве элементы, у которых оба индекса четные на их квадраты)

        int m = ReadInt("Введите колличество столбцов ");
        int n = ReadInt("Введите колличество строк ");

        int[,] array = NewArray(m, n, -10, 10);

        Console.WriteLine("Массив до изменения: ");
        PrintArray(array);

        for (int i = 2; i < array.GetLength(0); i++)
        {
            for (int j = 2; j < array.GetLength(1); j++)
            {
                if (i % 2 == 0 && j % 2 == 0)
                    array[i, j] *= array[i, j];
            }
        }

        Console.WriteLine("Массив после изменения(Где * возведение в квадрат)");
        PrintArray2(array);


        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void FourthTask()
    {//Задача 4 (Программа для замены элементов первой и последней строки)
        int m = ReadInt("Введите колличество столбцов ");
        int n = ReadInt("Введите колличество строк ");

        int[,] array = NewArray(m, n, -10, 10);
        int[] arr = new int[n];
        Console.WriteLine("Массив до изменения: ");
        PrintArray(array);
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arr[j] = array[i, j];
                array[i, j] = array[array.GetLength(0) - 1, j];
                array[array.GetLength(0) - 1, j] = arr[j];
            }
        }
        Console.WriteLine("Массив после изменения: ");
        PrintArray(array);

        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
}
void PrintArray2<T>(T[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
                Console.Write($"{arr[i, j]}* \t");
            else
                Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintArray<T>(T[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] NewArray(int sizeColumn, int sizeRow, int min, int max)
{
    int[,] arr = new int[sizeColumn, sizeRow];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
}