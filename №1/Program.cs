//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число А");
string input = Console.ReadLine();
int a = int.Parse(input);
Console.WriteLine("Введите число Б");
int b = int.Parse(input2);
int max = 0;
int min = 0;

if (a > b) max = a;
if (a > b) min = b;
if (b > a) max = b;
if (b > a) min = a;

Console.WriteLine("Большее число = ");
Console.WriteLine(max);
Console.WriteLine("Меньшее число = ");
Console.WriteLine(min);
