//Задача 4
//Напишите программу, которая принимает на вход три 
//числа и выдаёт максимальное из этих чисел.


Console.Write("Введите a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("c: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1>num2 && num1>num3)
{
    Console.WriteLine($"a {num1} больше двух других");
}
else if (num2>num1 && num2>num3)
{
   Console.WriteLine($"b {num2} больше двух других");
}
else
{
    Console.WriteLine($"c {num3} больше двух других");
}