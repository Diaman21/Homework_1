//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    Console.WriteLine($"а {num1} больше, чем b {num2}");
}
else
{
   Console.WriteLine($"b {num2} больше, чем a {num1}");
}