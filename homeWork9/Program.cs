while (true)
{
    Console.WriteLine("1) Показать натуральные числа от N до 1, N задано ");
    Console.WriteLine("2) Показать натуральные числа от M до N, N и M заданы ");
    Console.WriteLine("3) Найти сумму элементов от M до N, N и M заданы ");
    Console.WriteLine("4) Написать программу вычисления функции Аккермана ");
    Console.WriteLine("5) Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих ");
    Console.WriteLine("0) Закончить программу ");
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
    if (task == 0)
        break;

    void FirstTask()
    { // задача 1 (Показать натуральные числа от N до 1, N задано)
        int a = ReadInt("Введите число: ");
        RecursionOfTheFirstTask(a);

        System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
        System.Console.ReadKey();
    }
    void RecursionOfTheFirstTask(int a)
    {
        if (a == 1)
        {
            Console.WriteLine(a);
            return;
        }
        Console.WriteLine(a);
        RecursionOfTheFirstTask(a - 1);
    }

    void SecondTask()
    {   // задача 2 (Показать натуральные числа от M до N, N и M заданы )
        int m = ReadInt("Введите число от которого начинать: ");
        int n = ReadInt("Введите число до которого показывать: ");

        if (m < n)
        { RecursionOfTheSecondTask(m, n); }
        else
        { RecursionOfTheSecondTask2(m, n); }



        System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
        System.Console.ReadKey();
    }
    void RecursionOfTheSecondTask(int m, int n)
    {
        if (m > n)
            return;

        Console.WriteLine(m);
        RecursionOfTheSecondTask(m + 1, n);
    }
    void RecursionOfTheSecondTask2(int m, int n)
    {
        if (m < n)
            return;

        Console.WriteLine(m);
        RecursionOfTheSecondTask2(m - 1, n);
    }


    void ThirdTask()
    {     //задача 3 (Найти сумму элементов от M до N, N и M заданы ");)
        int m = ReadInt("Введите число от которого начинать: ");
        int n = ReadInt("Введите число до которого показывать: ");
        int a;
        if (m < n)
            a = RecursionOfTheThirdTask(m, n);
        else
            a = RecursionOfTheThirdTask(n, m);

        System.Console.WriteLine($"Результат сложения чисел от {m}  до {n} равен {a}");

        System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
        System.Console.ReadKey();
    }
    int RecursionOfTheThirdTask(int m, int n)
    {
        if (m == n)
            return m;
        return m + RecursionOfTheThirdTask(m + 1, n);
    }

    void FourthTask()
    {   // Задача 4 (Написать программу вычисления функции Аккермана)
        int m = ReadInt("Введите начальное число M: ");
        int n = ReadInt("Введите начальное число N: ");
        
        Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");

        System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
        System.Console.ReadKey();

    } 
    ///Метод вычисления функции Аккермана:
     int AckermannFunction(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
            if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
            return AckermannFunction(m, n);
        }
    void FifthTask()
    {   // Задача 5 (Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих)

        int a = ReadInt("Введите первое число: ");
        int b = ReadInt("Введите второе число: ");

        RecursionOfTheFifthTask(a, b, 5);

        System.Console.WriteLine();
        System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
        System.Console.ReadKey();
    }
    void RecursionOfTheFifthTask(int a, int b, int count)
    {
        Console.Write($"{a} {b} ");
        int c = a + b;
        int d = b + c;
        if (count < 0)
            return;
        RecursionOfTheFifthTask(c, d, count - 1);
    }
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
