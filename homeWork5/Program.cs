while (true)
{  
    Console.WriteLine("1)Найти точку пересечения двух прямых; \n2)Показать числа Фибоначчи; \n3)Написать программу масштабирования фигуры ;\n4)Написать программу копирования массива; \n0)Закончить программу. ");
    Console.Write("Выберите задачу: ");
    int task = Convert.ToInt32(Console.ReadLine());
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
    {//Задача 1 (Найти точку пересечения двух прямых заданных уравнением)

        double b1 = ReadInt("Введите значение b1: ");
        double k1 = ReadInt("Введите число k1: ");
        double b2 = ReadInt("Введите значение b2: ");
        double k2 = ReadInt("Введите число k2: ");

        double x = (-b2 + b1) / (-k1 + k2);
        double y = k2 * x + b2;

        Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void SecondTask()
    {//Задача 2 (Показать числа Фибоначчи)        
        int firstValue = ReadInt("Введите первое число: ");
        int secondValue = ReadInt("Введите второе число: ");

        int[] array = new int[10];
        array[0] = firstValue;
        array[1] = secondValue;

        for (int i = 2; i < array.Length; i++)
        { array[i] = array[i - 2] + array[i - 1]; }

        Console.WriteLine(string.Join(" ", array));

        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void ThirdTask()
    {//Задача 3 (Написать программу масштабирования фигуры)
        Console.WriteLine("Задайте вершины фигуры. \n Пример: (0,-1)(33,0)(10,3)(100,-22) \n");
        string figure = Console.ReadLine() ?? "0";
        Console.WriteLine("Введите маштаб: ");
        float scale = float.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Ваши координаты до маштабирования: {figure}");

        figure = ChangeScale(figure, scale);

        Console.WriteLine($"Ваши вершины после изменения маштаба: {figure}");

        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }

    string ChangeScale(string str, float scale)  // метод для маштабирования (3 задача)
    {
        string[] nums = new string[8];  // создал массив строк(для умножения цифр)
        float swap;
        int count = 0;
        for (int i = 0; i < str.Length; i++) // перебор символов строки
        {                                                                              // поиск цифр в строке
            if (str[i] == '0' || str[i] == '1' || str[i] == '2' || str[i] == '3' || str[i] == '4' || str[i] == '5' || str[i] == '6' || str[i] == '7' || str[i] == '8' || str[i] == '9' || str[i] == '-')
            {
                while (i < str.Length)
                {             // если попадёт какой либо знак, то запись в определённый индекс массива прекратится
                    if (str[i] == '(' || str[i] == ')' || str[i] == ',' || str[i] == ' ')
                    {
                        count++; // + к счётчику для записи в след месте массива строк
                        break;
                    }
                    nums[count] += str[i];  // запись цифр из строки в массив строк
                    i++;
                }
            }

        }   // этот цикл для маштабирования 
        for (int i = 0; i < nums.Length; i++)
        {
            swap = int.Parse(nums[i]) * scale;  // результат маштабирования
            nums[i] = Convert.ToString(swap);   // занёт результат машт. обратно в массив строк
        }
        string result = $"({nums[0]},{nums[1]})({nums[2]},{nums[3]})({nums[4]},{nums[5]})({nums[6]},{nums[7]})";  // вывел результат
        return result;
    }

    void FourthTask()
    {//Задача 4 (Написать программу копирования массива)
        int size = ReadInt("Введите размер массива: ");
        int min = ReadInt("Введите минимальный диапозон: ");
        int max = ReadInt("Введите максимальный диапозон: ");
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(min, max);
        }
        Console.WriteLine("Числа вашего массива " + string.Join(", ", arr));

        int[] newArray = CopyArray(arr);   // вызов метода для копирования массива

        Console.WriteLine("Числа нового массива " + string.Join(", ", newArray));


        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
}

int[] CopyArray(int[] arr)   // метод для копирования массива для 4 задачи
{
    int[] array = new int[arr.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = arr[i];
    }
    return array;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}