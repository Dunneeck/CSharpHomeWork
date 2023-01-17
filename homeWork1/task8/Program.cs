// задача 8 (Показать 2ю цифру 3х значного числа)
int num = new Random().Next(100, 999);
int res = num / 10 % 10;
Console.WriteLine($"Вторая цифра числа {num} равна {res}.");
