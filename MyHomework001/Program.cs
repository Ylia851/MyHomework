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

/*Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
2,3,7 - 7
44,5,78 - 78
22,3,9 - 22
*/

Console.WriteLine("Введите первое число");
Console.WriteLine("Введите второе число");
Console.WriteLine("Введите третье число");
int numbera = Convert.ToInt32(Console.ReadLine());
int numberb = Convert.ToInt32(Console.ReadLine());
int numberc = Convert.ToInt32(Console.ReadLine());

int max = numbera;

if (numbera > max) max = numbera;
if (numberb > max) max = numberb;   
if (numberc > max) max = numberc;   

Console.WriteLine("max = ");
Console.WriteLine(max);

/*
Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)
4 - Да
-3 - нет
7 - нет
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1);

int result = number%2;

if (result == 0) Console.WriteLine("Число четное");
if (result == 1) Console.WriteLine("Число нечетное");

/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
5 - 2.4
8 - 2.4.6.8
*/

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= num)
{
    Console.WriteLine(current);
    current = current + 2;  
}