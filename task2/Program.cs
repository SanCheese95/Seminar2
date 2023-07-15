// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введитк число: ");
int num = int.Parse (Console.ReadLine());
string anyNum = Convert.ToString(num);
if(anyNum.Length > 2) Console.WriteLine($" -> {anyNum[2]}");
else Console.WriteLine($"{num} -> третьей цифры нет");