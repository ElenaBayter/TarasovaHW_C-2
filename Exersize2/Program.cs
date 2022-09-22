// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(1, 1000000000);
Console.WriteLine(number);

int num1 = number/10;

while (num1 > 999)
{
    num1 = num1/10;
}
int num2 = num1 % 10;
Console.WriteLine($"Third digit is {num2}");

if (number < 100)
{
    Console.WriteLine("Your number is less then 100 so there are no third item");
}

