/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, ч
то третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine($"Напиши любое число: ");
string N = Console.ReadLine();
int UN = int.Parse(N);
int FN = (UN % 10)/1;
int FC = (UN % 100)/10;
int FV = (UN % 1000)/100;
 
if (UN > 100 && UN < 999)
    Console.WriteLine($"{FN}");
 
else if (UN > 1000 && UN < 9999)
    Console.WriteLine($"{FC}"); 
 
else if (UN > 10000)
    Console.WriteLine($"{FV}");     
else 
    Console.WriteLine("Третьей цифры нет");