// задача 11 (выяснить кратно ли второе число первому)
Console.WriteLine("Задавате любое число больше 0.");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте число на которое будет делиться число {num}");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num % num2 == 0)
   Console.WriteLine($"Число {num2} кратно числу {num}.");
else
   Console.WriteLine($"Число {num2} не кратно числу {num}. Остаток равен {num % num2}.");