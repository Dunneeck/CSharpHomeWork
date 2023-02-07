while (true)
{
    Console.WriteLine("1) Упорядочивание элементов двумерного массива по убыванию в каждой строке;");
    Console.WriteLine("2) Замена элементов строк на элементы столбцов;");
    Console.WriteLine("3) Найти в прямоугольной матрице стоку с наименьшей суммой элементов;");
    Console.WriteLine("0) Завершить работу");
    int task = ReadInt("Выберите задачу: ");
    if (task == 1)
        FirstTask();
    if (task == 2)
        SecondTask();
    if (task == 3)
        ThirdTask();
    if (task == 0)
        break;

    void FirstTask()
    {//Задача 1 (Упорядочивание элементов двумерного массива по убыванию в каждой строке)
        int m = ReadInt("Введите колличество столбцов ");
        int n = ReadInt("Введите колличество строк ");
        int max, index = 0;
        int[,] arr = NewArray(m, n, -10, 10);

        Console.WriteLine("Массив до сортировки: ");
        PrintArray(arr);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                max = arr[i, j];
                index = j;
                for (int k = j + 1; k < arr.GetLength(1); k++)
                {
                    if (arr[i, k] > max)
                    {
                        max = arr[i, k];
                        index = k;
                    }
                }
                max = arr[i, index];
                arr[i, index] = arr[i, j];
                arr[i, j] = max;
            }
        }
        Console.WriteLine("Массив после сортировки: ");
        PrintArray(arr);

        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void SecondTask()
    {//Задача 2 (Замена элементов строк на элементы столбцов)

        int m = ReadInt("Введите колличество столбцов ");
        int n = ReadInt("Введите колличество строк ");

        int[,] arr = NewArray(m, n, -10, 10);


        if (m != n)
            Console.WriteLine($"В заданном массиве невозможно перевести элем. строк в элем. столбцов!");
        else
        {
            int[,] newArr = new int[m, n];
            Console.WriteLine("Массив до изменения: ");
            PrintArray(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    newArr[j, i] = arr[i, j];
                }
            }
            Console.WriteLine("Массив после изменения: ");
            PrintArray(newArr);
        }
        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void ThirdTask()
    {//Задача 3 (Найти в прямоугольной матрице стhоку с наименьшей суммой элементов)        
        int[,] arr = NewArray(6, 6, 0, 10);
        int[] minRow = new int[6];
        int row = 0, min = 0;
        PrintArray(arr);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                min += arr[i, j];
            }
            minRow[i] = min;
            min = 0;
        }
        min = minRow[0];
        for (int i = 1; i < minRow.Length; i++)
        {
            if (minRow[i] < min)
            {
                min = minRow[i];
                row = i;
            }
        }
        Console.WriteLine($"Минимальное сумма элементов стоки {row}(или {row + 1} если не считать с 0) равна {min}");


        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
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
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
