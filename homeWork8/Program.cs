
while (true)
{
    Console.WriteLine("1) Частотный словарь одномерного массива;");
    Console.WriteLine("2) Частотный словарь двумерного массива;");
    Console.WriteLine("3) Частотный словарь строки;");
    Console.WriteLine("4) Показать произведение двух матриц;");
    Console.WriteLine("5) Удалить сроку и столбец на пересечении которых расположен наим. элем. в двум. массиве;");
    Console.WriteLine("6) Показать неповторяющиеся двухзначные числа(с их индексом) строкой в трехмерном массиве;");
    Console.WriteLine("7) Показать треугольник Паскаля(в виде равнобедренного треугольника);");
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
    if (task == 5)
        FifthTask();
    if (task == 6)
        SixthTask();
    if (task == 7)
        SeventhTask();
    if (task == 0)
        break;

    void FirstTask()
    {//Задача 1 (Частотный словарь одномерного массива)
        Console.WriteLine("Задайте любой диапозон цифр: ");
        int min = ReadInt("Введите с какой цифры начать поиск: ");
        int max = ReadInt("Введите до какой цифры искать ");
        int[] array = NewArr(min, max);
        int[] nums = NewArrFromMinToMax(min, max);
        int[] count = new int[array.Length];
        Console.WriteLine($"Ваш массив: ");
        PrintArr(array);
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == nums[i])
                    count[i]++;
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"Число {nums[i]} попадалось {count[i]} раз");
        }




        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }

    void SecondTask()
    {//Задача 2 (Частотный словарь двумерного массива)

        int min = ReadInt("Введите с какой цифры начать  поиск: ");
        int max = ReadInt("Введите до какой цифры: ");
        int[,] array = NewArray(5, 5, min, max);
        int[] nums = NewArrFromMinToMax(min, max);
        int[] count = new int[nums.Length];
        Console.WriteLine("Ваш массив: ");
        PrintArray(array);
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (nums[i] == array[j, k])
                        count[i]++;
                }
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"Число {nums[i]} попадалось {count[i]} раз");
        }



        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void ThirdTask()
    {//Задача 3 (Частотный словарь строки)        
        char[] chars = new char[36] { 'й', 'б', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'ж', 'э', 'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'б', 'ю', ' ', ',', '.', '–' };

        int[] count = new int[36];

        double res = 0;

        string str = "Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования.";
        str.ToLower();
        int length = str.Length;
        for (int i = 0; i < chars.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == chars[i])
                    count[i]++;
            }
        }

        for (int i = 0; i < count.Length; i++)
        {
            res = Math.Round(Convert.ToDouble(count[i]) / Convert.ToDouble(length) * 100, 3);

            if (count[i] == 0)
                Console.WriteLine($"Символ {chars[i]} встречается {count[i]} раз. Частота 0 %");
            else
                Console.WriteLine($"Символ {chars[i]} встречается {count[i]} раз.   Частота {res} %");
        }



        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void FourthTask()
    {//Задача 4 (Показать произведение двух матриц)        

        int[,] firstFactor = NewArray(3, 3, 1, 11);
        int[,] secondFactor = NewArray(3, 3, 1, 11);
        for (int i = 0; i < firstFactor.GetLength(0); i++)
        {
            for (int j = 0; j < firstFactor.GetLength(1); j++)
            {
                Console.WriteLine($"{secondFactor[i, j]} * {firstFactor[i, j]} = {secondFactor[i, j] * firstFactor[i, j]}");
            }
            Console.WriteLine();
        }
       

        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void FifthTask()
    {//Задача 5 (Удалить сроку и столбец на пересечении которых расположен наим. элем. в двум. массиве)        
        int[,] array = new int[6, 6]; // создал основной массив
        Random rnd = new Random();
        int[] array2 = new int[array.Length]; // создал др. массив чтобы заполнить неовторяющимися цифрами
        for (int i = 0; i < array2.Length; i++)
        {                                            // цикл записывает цифры
            array2[i] = rnd.Next(-50, 50);
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)        //   тут идёт проверка(чтобы не было повторок)
                {
                    while (array2[i] == array2[j])
                    {
                        array2[i] = rnd.Next(-50, 50);
                        j = 0;
                    }
                }
            }
        }
        for (int i = 0, a = 0; i < array.GetLength(0); i++)
        {                                                  // заполняет осн. массив с др массива цифрами
            for (int j = 0; j < array.GetLength(1); j++, a++)
            {
                array[i, j] = array2[a];
            }
        }

        Console.WriteLine("Массив до изменения: ");
        PrintArray(array);

        int min = array[0, 0];
        int deleteRow = 0, deleteColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {                                               // здесь я нахожу мин. число и запоминаю его координаты
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    deleteRow = i;
                    deleteColumn = j;
                }
            }
        }

        Console.WriteLine($"Минимальное число: {min} - строка: {deleteRow}; столбец: {deleteColumn}");

        int[,] array3 = new int[5, 5];

        for (int i = 0, a1 = 0; i < array.GetLength(0); i++)
        {                                  // здесь я записываю с основного массива в 3 массив цифры 
            if (deleteRow == i)            // за исключением не нужных сток и столбцов
                continue;
            for (int j = 0, b1 = 0; j < array.GetLength(1); j++)
            {
                if (deleteColumn == j)
                    continue;
                array3[a1, b1] = array[i, j];
                b1++;
            }
            a1++;
        }
        Console.WriteLine("Массив после изменения: ");
        PrintArray(array3);


        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void SixthTask()
    {//Задача 6 (Показать неповторяющиеся двухзначные числа(с их индексом) строкой в трехмерном массиве)        
        int[,,] arr = new int[3, 3, 2];
        Random rnd = new Random();
        int[] array = new int[arr.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0, 20);
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (array[i] == array[j])
                    {
                        array[i] = rnd.Next(0, 20);
                        j = 0;
                    }
                }
            }
        }
        for (int i = 0, a = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    arr[i, j, k] = array[a];
                    a++;
                    Console.WriteLine($"{arr[i, j, k]}: i={i}, j={j}, k={k}");
                }
            }
        }



        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void SeventhTask()
    {//Задача 7 (Показать треугольник Паскаля(в виде равнобедренного треугольника))        
        int a = ReadInt("Сколько рядов вам показать? ");
        int[,] arr = new int[a, a];
        int b = ReadInt("Скакой цифры начать? ");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            arr[i, 0] = b;
            arr[i, i] = b;
            if (i < 1)
                continue;
            for (int j = 1; j < i; j++)
            {
                arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
            }
        }
        string ch =  "  ";
        int count = a;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (arr[i, j] == 0)
                    continue;
                while (count > 1)
                {
                    Console.Write(ch);
                    count--;
                }
                if(arr[i,j]<10)
                Console.Write("  " +arr[i, j] + " ");
                else
                Console.Write(" " +arr[i, j] + " ");

            }
            count = a - i - 1;
            Console.WriteLine();
        }

        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
}


int[,] NewArray(int sizeColumn, int sizeRow, int min, int max)
{
    int[,] arr = new int[sizeColumn, sizeRow];
    if (min < max)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(min, max + 1);
            }
        }
        return arr;
    }
    else
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(max, min + 1);
            }
        }
        return arr;
    }

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

int[] NewArr(int min, int max)
{
    if (min < 0)
    {
        int tmp = -min;
        int[] nums = new int[tmp + 1 + max + 20]; //+20 чтоб показать больше цифр
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = new Random().Next(min, max + 1);
        }
        return nums;
    }
    else if (max < 0 && min < 0)
    {
        int tmp = -min;
        int[] nums = new int[tmp + max + 20];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = new Random().Next(min, max + 1);
        }
        return nums;
    }
    else if (max < min)
    {
        int[] nums = new int[min - max + 20];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = new Random().Next(max, min + 1);
        }
        return nums;
    }
    else
    {
        int[] nums = new int[max + 1 + 20];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = new Random().Next(min, max + 1);
        }
        return nums;
    }
}

int[] NewArrFromMinToMax(int min, int max)
{
    if (max < 0 && min < 0)
    {
        int tmp;
        if (max < min)
        {
            tmp = max;
            max = min;
            min = tmp;
        }
        tmp = -min;
        int[] nums = new int[tmp + max + 1];
        for (int i = 0; i < nums.Length; i++)
        {

            nums[i] = min;
            min++;
        }
        return nums;

    }
    else if (min < 0)
    {
        int tmp = -min;
        int[] nums = new int[tmp + 1 + max];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = min;
            min++;
        }
        return nums;
    }

    else if (max < min)
    {
        int[] nums = new int[min - max + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = max;
            max++;
        }
        return nums;
    }
    else
    {
        int[] nums = new int[max + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = min;
            min++;
        }
        return nums;
    }
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
