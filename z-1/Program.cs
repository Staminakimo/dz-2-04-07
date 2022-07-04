/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine($"Напиши любое трехзначное число: ");
string number = Console.ReadLine();
int usNumber = int.Parse(number);

int secondDigit = usNumber / 10;  
int findDigit = secondDigit % 10;  

Console.WriteLine($"{findDigit}"); 
