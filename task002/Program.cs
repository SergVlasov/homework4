// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 | 82 -> 10 | 9012 -> 12

Console.WriteLine("Hello. Enter a number:");
int num = Convert.ToInt32(Console.ReadLine());
int i =1;
int sum = 0;
while (num != 0)
{
    i = num % 10;
    sum = sum + i;
    num = num / 10;
}
Console.WriteLine(sum);