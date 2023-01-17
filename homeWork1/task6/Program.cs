// задача 6 (четные числа от 1 до N)
    System.Console.WriteLine("Введите число до которого будут проверяться числа на чётность.");
 int num = Convert.ToInt32(System.Console.ReadLine());
int i = 1;
System.Console.WriteLine("Ваши четные числа: ");
while(i <= num){
    if(i % 2 ==0){ 
        System.Console.WriteLine(i);
        i +=2;
    }
    else
    i++;
} 