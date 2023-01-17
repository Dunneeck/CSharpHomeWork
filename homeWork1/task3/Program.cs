// задача 3 (вывести день недели по заданному числу от пользователя)
System.Console.WriteLine("Введите число дня которое вам нужно");
int numDayOfWeek = Convert.ToInt32(Console.ReadLine());
string[] dayOfWeek = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
switch(numDayOfWeek){
    case 1:    
         Console.WriteLine(dayOfWeek[0]); break;
    case 2:    
         Console.WriteLine(dayOfWeek[1]); break;
     case 3:    
         Console.WriteLine(dayOfWeek[2]); break;
     case 4:    
         Console.WriteLine(dayOfWeek[3]); break;
     case 5:    
         Console.WriteLine(dayOfWeek[4]); break;
     case 6:    
         Console.WriteLine(dayOfWeek[5]); break;
     case 7:    
         Console.WriteLine(dayOfWeek[6]); break;
     
}
