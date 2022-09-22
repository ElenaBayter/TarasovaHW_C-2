// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Write number");
int number = int.Parse(Console.ReadLine());

int num1 = number % 100;
int num2 = number % 10;
int num3 = (num1 - num2) / 10;
Console.WriteLine(num3);
