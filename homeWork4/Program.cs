while (true)
{
    Console.WriteLine("1) Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
    Console.WriteLine("2) Определиит, присутствует ли в заданном массиве, некоторое число");
    Console.WriteLine("3) Задать массив, заполнить случайными положительными 3х значными числами. Показать колличество нечетных и четных чисел");
    Console.WriteLine("4) В одномерном массиве из 123 чисел найти колличиство элементов из отрезка [10,99]");
    Console.WriteLine("5) Найти сумму чисел одномерного массива стоящих на нечетной позиции");
    Console.WriteLine("6) Найти произведение пар чисел в одномерном массиве(первой и последней и тд)");
    Console.WriteLine("7) В указанном массиве вещественных чисел найдите разницу между макс. и мин. элементом");
    Console.WriteLine("0) Завершить работу");
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
    if (task == 5)
        FifthTask();
    if (task == 6)
        SixthTask();
    if (task == 7)
        SeventhTask();
    if (task == 0)
        break;
    void FirstTask()
    {//Задача 1 (Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран)
        int[] array = { 0, 1, 0, 1, 0, 1, 0, 1 };
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Элемент массива {array[i]} под индексом {i}.");
        }
        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void SecondTask()
    {//Задача 2 (Определиить, присутствует ли в заданном массиве, некоторое число)
        int[] array = new int[10];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-11, 11);
        }
        Console.Write("Какое число вам нужно найти(диапозон от -10 до 10): ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < array.Length; i++)
        {

            if (num == array[i])
            {
                Console.WriteLine($"Число {num} присутствует в массиве под индексом {i}");
                count++;
            }

        }
        if (count == 0)
            Console.WriteLine(" Данного числа нет");

        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void ThirdTask()
    {//Задача 3 (Задать массив, заполнить случайными положительными 3х значными числами. Показать колличество нечетных и четных чисел)
        int[] array = new int[10];
        int countEven = 0, countOdd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(99, 1000);
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                countEven++;
            }
            else
                countOdd++;
        }
        Console.WriteLine($"Количиство четных чисел {countEven}\n Количество нечетных чисел {countOdd}");
        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void FourthTask()
    {//Задача 4 (В одномерном массиве из 123 чисел найти колличиство элементов из отрезка [10,99])
        int[] array = new int[123];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 999);
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 100 && array[i] > 10)
            {
                count++;
            }

        }
        Console.WriteLine($"Количество цифр из отрезка(от 10 до 99) будет {count}");
        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void FifthTask()
    {//Задача 5 (Найти сумму чисел одномерного массива стоящих на нечетной позиции)
        int[] array = new int[10];
        int res = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 10);
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            res += array[i];
        }
        Console.WriteLine($"Сумма чисел массива на нечетном индексе равна {res}");
        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void SixthTask()
    {//Задача 6 (Найти произведение пар чисел в одномерном массиве(первой и последней и тд)
        int[] array = new int[10];
        int res = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 10);
        }
        for (int i = 0, j = 9; i < j; i++, j--)
        {
            res = array[i] * array[j];
            Console.WriteLine($"Произведение чисел {array[i]} и {array[j]} равно {res}");
        }
        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
    void SeventhTask()
    {//задача 7 (В указанном массиве вещественных чисел найдите разницу между макс.и мин. элементом)
        double[] array = new double[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-10, 10) + new Random().NextDouble();
        }
        double res = 0, maxValue = array[0], minValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (maxValue < array[i])
                maxValue = array[i];

            if (minValue > array[i])
                minValue = array[i];
        }
        res = maxValue - minValue;
        Console.WriteLine($"Разница между макс.{maxValue} и мин. {minValue} значениями равна {res}");
        Console.WriteLine("\nНажмите пробел для продолжения\n");
        Console.ReadKey();
    }
}

