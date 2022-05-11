/* Задача 34. Задайте массив, заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве
[345, 897, 568, 234] - 2
*/

int[] CreateRandomArray (int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }

    return array;

}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");
}

void FindAmoundOfElements (int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine("Sum of positive elements is " + count);
}

int [] myArray = CreateRandomArray(4, 100, 999);
ShowArray(myArray);
FindAmoundOfElements(myArray);

/*Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
[3,7,23,12] - 19
[-4,-6,89,6] - 0
*/

void FindSumOfElements (int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
            sum = sum + array[i];
    }
    Console.WriteLine("Sum of elements jn negative position is " + sum);
}

int [] newArray = CreateRandomArray(4, -100, 999);
ShowArray(newArray);
FindSumOfElements(newArray);

/*Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным размером массива.
[3,7,22,2,78] - 76
*/

void FindDifOfElements (int[] array)
{
    int min = array[0];
    int max = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        else if(array[i] > max)
            max = array[i];
    }
    Console.Write("Diference between max and min elements is ");
    Console.WriteLine(max - min);
}

int [] difArray = CreateRandomArray(10, -100, 999);
ShowArray(difArray);
FindDifOfElements(difArray);





