/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом.
14212-не является
12821 - да
23432 - да
*/

void NumPalindron()
{
    Console.WriteLine("Введите пятизначное число");
    int num = Convert.ToInt32(Console.ReadLine());
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num3 = (num / 10) % 10;
    int num4 = num % 10;

    if (num1 == num4 || num2 == num3)
        Console.WriteLine("Число является полиндромом");
    else 
        {
            Console.WriteLine("Число не является полиндромом");    
        }
}

NumPalindron();

/*
Напишите программу, которая принимает на вход координты двуч точек и находит расстояние между ними в 3D пространстве
А (3,6,8) и В (2,1,-7) - 15,84
А (7,-5,0) и В (1,-1,9) - 11,53
*/

double Sqrt(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

Console.WriteLine("Введите координату х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sqrt(x1, x2, y1, y2, z1, z2));


/*Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
3 = 1.8.27
5-1.8.27.64.125
*/

void Sqrt1 (int N)
{
    int count = 1;
    Console.Write(N + " - ");
        
    while (count <= N)
    {
        Console.Write(count * count * count + " ");
        count++;
    }
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Sqrt1(num);