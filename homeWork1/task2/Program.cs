// задача 2 (По двум заданным числам проверять является ли первое квадратом второго)
System.Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите число для проверки на квадрат 1го числа");
int num2 = Convert.ToInt32(System.Console.ReadLine());

if(num1 == num2 * num2)
 System.Console.WriteLine($"Число {num1} является квадратом числа {num2}");
else 
 System.Console.WriteLine($"Число {num1} не является квадратом числа {num2}");