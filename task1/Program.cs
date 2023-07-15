// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введитк число: ");
int num = int.Parse (Console.ReadLine());
int newNum = num / 10;
newNum = newNum % 10;
Console.WriteLine($"{num} -> {newNum}");
