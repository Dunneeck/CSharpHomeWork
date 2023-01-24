while (true)
{
    System.Console.WriteLine("Выберите какую задачу вам показать и нажмите соответствующую цифру: \n 1)Найти кубы чисел от 1 до N  \n 2)Подсчитать сумму цифр в числе \n 3)Вычисления произведения чисел от 1 до N  \n 4)Показать кубы чисел, заканчивающихся на четную цифру  \n 0)Закончить программу");
    int task = Int32.Parse(Console.ReadLine() ?? "0");
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
}
void FirstTask()
{ //   (Найти кубы чисел от 1 до N)
    System.Console.Write("Введите число:  ");
    int value = Int32.Parse(Console.ReadLine() ?? "0"), res;
    for (int i = 1; i <= value; i++)
    {
        res = i * i * i;
        System.Console.WriteLine($"Куб  числа {i} равен {res}");
    }
    System.Console.WriteLine(" \n Нажмите пробел для прожолжения.\n");
    System.Console.ReadKey();
}
void SecondTask()
{//  (Подсчитать сумму цифр в числе)
    System.Console.Write("Введите число:  ");
    int value = Int32.Parse(Console.ReadLine() ?? "0");
    int res = 0;
    for (int i = value; i > 0;)
    {
        res += i % 10;
        i /= 10;
    }
    System.Console.WriteLine($"Сумма цифр в числе {value} равна {res}. \n");
    System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
    System.Console.ReadKey();
}
void ThirdTask()
{//  (Написать программу вычисления произведения чисел от 1 до N)
    System.Console.Write("Введите число:  ");
    int value = Int32.Parse(Console.ReadLine() ?? "0"), res = 1;
    for (int i = 1; i <= value; i++)
    {
        res *= i;
    }
    System.Console.WriteLine($"Произведение чисел от 1 до {value} равна {res}. \n");
    System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
    System.Console.ReadKey();
}
void FourthTask()
{//  (Показать кубы чисел, заканчивающихся на четную цифру)
    System.Console.Write("Введите число:  ");
    int value = Int32.Parse(Console.ReadLine() ?? "0"), res;
    for (int i = 2; i <= value; i += 2)
    {
        res = i * i * i;
        System.Console.WriteLine($"Куб  числа {i} равен {res}");
    }
    System.Console.WriteLine(" \n Нажмите пробел для прожолжения.\n");
    System.Console.ReadKey();
}

