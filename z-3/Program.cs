/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Напиши число деня недели: ");
string number = Console.ReadLine();
int day = int.Parse(number);

if (day == 1)
{
    Console.WriteLine("Сегодня рабочий день. Топай на работу");
}
else if (day == 2)
{
    Console.WriteLine("Сегодня рабочий день. Топай на работу");
}
else if (day == 3)
{
    Console.WriteLine("Сегодня рабочий день. Топай на работу");
}
else if (day == 4)
{
    Console.WriteLine("Сегодня рабочий день. Топай на работу");
}
else if (day == 5)
{
    Console.WriteLine("Сегодня рабочий день. Топай на работу");
}
else if (day == 6)
{
    Console.WriteLine("Расслабся, сегодня выходной");
}
else if (day == 7)
{
    Console.WriteLine("Расслабся, сегодня выходной");
}
else
{
    Console.WriteLine("В недели только 7 дней");
} 
