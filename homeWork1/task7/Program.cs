// задача 7 (Последняя цифра 3х значного числа)
Console.WriteLine("Введите 3х значное число.(можно и большее число)");
int num = Convert.ToInt32(Console.ReadLine());
int res = num % 10;
Console.WriteLine($"Последняя цифра числа {num} будет {res}");