/*
Задача 1. Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на глсную букву
Пример: {"qwe", "wer", "ert", "rty", "tyu"} -> 1
*/

string[] names = {"qwe", "wer", "ert", "rty", "tyu"};
int SumWords(string[] words)
{
    int count = 0;
    for(int i = 0; i < words.Length; i++)
    {
        for(int j = 0; j < words.Length; j++)
        {
            if(words[i][j] == 'a' || words[i][j] == 'e' || words[i][j] == 'i' || words[i][j] == 'o' || words[i][j] == 'u' || words[i][j] == 'y') 
                count += 1;
        }
    }
    return count;
}


void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
PrintArray(names);
Console.WriteLine();
PrintArray(SumWords(names));


/*Задача 2. Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно
Пример: {"qwe", "wer", "ert", 'rty", "tyu", "yui"} -> {"qwewer", "ertrty", "tyuyui"}
*/

//string[] names = {"qwe", "wer", "ert", "rty", "tyu", "yui"};

string[] NtArray(string[] words)
{
    int size = words.Length / 2;
    for (int i = 0, j = 0; i < words.Length - 1; i += 2, j++)
    {
        words[j] = words[i] + words[i + 1];
    }
    return words;
}
PrintArray(names);
Console.WriteLine();
PrintArray(NtArray(names));