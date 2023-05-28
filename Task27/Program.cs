/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int res = 0;
int temp1 = N;
int temp2 = N;
while (temp1 > 0)
{
    temp2 = temp1%10; 
    temp1 = temp1 /10;  
    res = res + temp2;
}
Console.Write($"{res}");