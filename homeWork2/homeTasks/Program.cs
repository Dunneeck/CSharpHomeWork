// Решил попробовать сделать дз в одной папке и чтобы вы могли выбрать нужную вам задачу. Запустите консоль и далее следуйте инструкциям.
// Надеюсь это не усложнит проверку
while (true)
{
    System.Console.WriteLine("Выберите какую задачу вам показать и нажмите соответствующую цифру: \n 1) Дано число обозначающее день недели. Выяснить является ли номер дня недели выходным \n 2) По двум заданным числам проверять является ли одно квадратом другого \n 3) Задать номер четверти, показать диапазоны для возможных координат \n 4) Найти расстояние между точками в пространстве 2D/3D \n 0) Закончить программу");
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
{ //Дано число обозначающее день недели. Выяснить является номер дня недели выходным
    System.Console.WriteLine("Введите число дня которое вам нужно.");
    int numDayOfWeek = Convert.ToInt32(Console.ReadLine());
    string[] dayOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    switch (numDayOfWeek)
    {
        case 1:
            Console.WriteLine($"{dayOfWeek[0]} не выходной день.\n"); break;
        case 2:
            Console.WriteLine($"{dayOfWeek[1]} не выходной день.\n"); break;
        case 3:
            Console.WriteLine($"{dayOfWeek[2]} не выходной день.\n"); break;
        case 4:
            Console.WriteLine($"{dayOfWeek[3]} не выходной день.\n"); break;
        case 5:
            Console.WriteLine($"{dayOfWeek[4]} не выходной день.\n"); break;
        case 6:
            Console.WriteLine($"Да это же {dayOfWeek[5]}. Это выходной день. \n"); break;
        case 7:
            Console.WriteLine($"Да это же {dayOfWeek[6]}. Это выходной день. \n"); break;
        default: 
        System.Console.WriteLine($"Дня под цифрой {numDayOfWeek} не существует. \n"); break;
    }
    System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
    System.Console.ReadKey();
}

void SecondTask()
{
    // задача 2 (По двум заданным числам проверять является ли первое квадратом второго)
    System.Console.WriteLine("Введите первое число(которое будет квадратом)");
    int num1 = Convert.ToInt32(System.Console.ReadLine());

    System.Console.WriteLine("Введите число для проверки на квадрат 1го числа");
    int num2 = Convert.ToInt32(System.Console.ReadLine());

    if (num1 == num2 * num2)
        System.Console.WriteLine($"Число {num2} в квадрате равно {num1}. \n");
    else
        System.Console.WriteLine($"Число {num2} в квадрате не равно {num1}. \n");

    System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
    System.Console.ReadKey();
}
    
void ThirdTask()
{     //задача 3 (Задать номер четверти, показать диапазоны для возможных координат)
    System.Console.WriteLine("Выберите четверть чтобы посмотреть его диапозон. ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 1)
    {
        System.Console.WriteLine("Диапозон первой четверти: X > 0  Y > 0 \n");
    }
    else if (x == 2)
    {
        System.Console.WriteLine("Диапозон второй четверти: X < 0  Y > 0 \n ");
    }
    else if (x == 3)
    {
        System.Console.WriteLine("Диапозон третьей четверти: X < 0  Y < 0 \n");
    }
    else if (x == 4)
    {
        System.Console.WriteLine("Диапозон четвертой четверти: X > 0  Y < 0 \n");
    }
    else
        System.Console.WriteLine("Такой четверти нет. \n");

    System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
    System.Console.ReadKey();
}

void FourthTask()
{   // Задача 4 (Найти расстояние между точками в пространстве 2D/3D)
    System.Console.WriteLine("Задайте координату для 2д точки по оси X ");
    int x2d = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Задайте координату для 2д точки по оси Y ");
    int y2d = Convert.ToInt32(Console.ReadLine()), z2d = 0;
    System.Console.WriteLine($"Координаты точки в 2д пространсте равны X = {x2d}; Y = {y2d}; Z = 0; (я перевел точку из 2д в 3д и присвоил ей Z = 0, чтобы можно было найти расстояние по формуле. \n");
    System.Console.WriteLine("Задайте координату для 3д точки по оси X ");
    int x3d = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Задайте координату для 3д точки по оси Y ");
    int y3d = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Задайте координату для 3д точки по оси Z ");
    int z3d = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"Координаты точки в 3д пространсте равны X = {x3d}; Y = {y2d}; Z = {z3d}; \n");

    // Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
    double res = Math.Sqrt(Math.Pow((x3d - x2d),2) + Math.Pow((y3d - y2d),2) + Math.Pow((z3d - z2d),2));

    System.Console.WriteLine($"Расстояние от точки до точки равно {res} \n");
    System.Console.WriteLine("Нажмите пробел для прожолжения.\n");
    System.Console.ReadKey();
    
}
  