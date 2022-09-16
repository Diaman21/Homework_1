//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<0)
{
    Console.Write("Введите положительное число");
}
else{
    while (num>1)
    {
        if ((num % 2) == 0)
        {
            Console.Write(num + ";");
        }
        num = num - 1;
    }
}