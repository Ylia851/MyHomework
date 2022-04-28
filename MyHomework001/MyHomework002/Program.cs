/*
Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
456-5
782-8
918-1
*/

void ShowNumber()
{
    Console.WriteLine("Input number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int n1 = n%100;
    int n2 = n1/10;

    Console.WriteLine(n2);
}

ShowNumber();

/* Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 - 5
32679 - 6
78 - третьей цифры нет
*/

void ShowNumber1()
{
    Console.WriteLine("Input number: ");
    int num= Convert.ToInt32(Console.ReadLine());
    if (num < 100)
        Console.WriteLine("Третьей цифры нет");
    else
    {
        while (num > 1000)
        {
            num = num/10;
        }
        if (num >= 100 || num < 1000)
        {
            num = num % 10;
            Console.WriteLine(" - " + num);
        }
    }
}
ShowNumber1();

/*
Задача 15. Напишите программу, которая принимает на вход цифру, обознчающую день недели, и проверяет, является ли этот день выходным.
6 - Да
7 - Да
1 - нет
*/

void DayOf ()
{
    Console.WriteLine("Input number o weekday: ");
    int numbday = Convert.ToInt32(Console.ReadLine());

    if (numbday > 7 || numbday < 1)
        Console.WriteLine("Incorrect number of day");
    else if (numbday > 0 || numbday <= 5)
        Console.WriteLine("День не является выходным");        
    else if (numbday == 6  || numbday == 7)
        Console.WriteLine("День выходной");
}

DayOf ();


