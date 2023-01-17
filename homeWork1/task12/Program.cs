// задача 12 (найти 3ю цифру 3х значного числа и сказать если 3 цифры нет)
int num = new Random().Next(1, 999);
Console.WriteLine($"Дано число {num}.");
if ( num > 99 )
{ int res = num % 10;
   Console.WriteLine($"Третья цифра числа {num} равна {res}");
}
else
   Console.WriteLine($"У числа {num} нет третьей цифры.");
