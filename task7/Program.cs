// Напишите программу, которая на вход принимает трехзначное число, а на выходе показывает последнюю цифру этого числа

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 10;
Console.Write($"Third number {number} = {result} ");