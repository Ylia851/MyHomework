/*Задача 66. Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.
М = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int SumOfElem(int m, int n)
{
    if (n >= m)
    {
       return (m + SumOfElem(m + 1, n));
    }
    else 
    {
        return 0;
    }
}   
Console.WriteLine("Input number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfElem(M, N));

/* Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
453-> 12
45->9
*/

int SumOfNums(int r)
{
    if(r < 10)
    {
        return r;
    }
    else
    {
        return (r%10)+SumOfNums(r/10);
    }
}   
Console.WriteLine("Input number: ");
int R = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfNums(R));
