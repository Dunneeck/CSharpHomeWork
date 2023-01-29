// System.Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 7 == 0 && num % 23 ==0)
// System.Console.WriteLine("Ваше число кратно 7 и 23.");
// else
// System.Console.WriteLine("Ваше число не кратно 7 и 23");

// System.Console.WriteLine("Задайте число для X ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Задайте число для Y ");
// int y = Int32.Parse(Console.ReadLine()!);

// if (x > 0 && y > 0)
// {
//     System.Console.WriteLine("Ваша точка в первой четверти");
// }
// if (x < 0 && y > 0)
// {
//     System.Console.WriteLine("Ваша точка в второй четверти");
// }
// if (x < 0 && y < 0)
// {
//     System.Console.WriteLine("Ваша точка третьей четверти");
// }
// if (x > 0 && y < 0)
// {
//     System.Console.WriteLine("Ваша точка в четвертой четверти");
// }

// System.Console.WriteLine("Введите пятизначное число ");
// int x = Convert.ToInt32(Console.ReadLine());

// int firstValue = x / 10000;
// int secondValue = x / 1000 % 10;
// int fourthValue = x % 100 / 10;
// int fifthValue = x % 10;

// if (firstValue == fifthValue && secondValue == fourthValue)
// System.Console.WriteLine("Ваше число палиндром");
// else 
// System.Console.WriteLine("Ваше число не палиндром");


// object[] arr  = {'h', "строка", 22, 22f, true};

//  System.Console.WriteLine(string.Join(", ", array));

// int x = Convert.ToInt32(Console.ReadLine());
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[] NewArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(min,max);
    return arr;
}




// int a = ReadInt("Введите первую сторону");
// int b = ReadInt("Введите вторую сторону");
// int c = ReadInt("Введите третью сторону");

// if (a + b > c && a + c > b && b + c > a)
// Console.WriteLine("У вас правильный треугольник");
// else
// Console.WriteLine("У вас не правильный треугольник");


//oписать программу преобразования десятичного числа в двоичное
// int x = ReadInt("Ваше число ");;
//     string s = "";
//     while (x > 0)
//     {
//         s = ((x % 2 == 0) ? "0" : "1") + s;
//         x /= 2;
//     }
//     Console.Write(s);

int[] ar = NewArray(5,-10,10);

System.Console.WriteLine(string.Join(" ", ar));



