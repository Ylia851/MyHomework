 /*
 Задача 1. Напишите программу, которая на входе принимает два числа и выдает, какое число большее, а какое меньшее
 а = 5  b = 7 - max = 7
 a = 2 b = 10 - max = 10
 a = -9 b = -3 - max = -3
*/

Console.WriteLine("Введите первое число");
Console.WriteLine("Введите второе число");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
    Console.WriteLine("max = " + numberA);
else
    Console.WriteLine("max = " + numberB);