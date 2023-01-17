// задача 9 (найти большую цифру из 2х значного числа)
int num = new Random().Next(10,99);
int firstValue = num / 10;
int secondValue = num % 10;
if (firstValue > secondValue)
   Console.WriteLine($"Наибольше цифра числа {num} равна {firstValue}.");
if (firstValue < secondValue)
   Console.WriteLine($"Наибольше цифра числа {num} равна {secondValue}.");   
if (firstValue == secondValue)
   Console.WriteLine($"Значения цифр числа {num} равны.");
