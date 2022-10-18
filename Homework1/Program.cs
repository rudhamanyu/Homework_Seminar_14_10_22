/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] GetArray(int length)
{
    int[] rndArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < rndArray.Length; i++)
        rndArray[i] = rnd.Next(100, 1000);
    return rndArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int NumberOfEven(int[] arr)
{
    int evenNum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            evenNum++;
    return evenNum;
}

Console.Write("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine() ?? "");
int[] arr = GetArray(length);
PrintArray(arr);
int even = NumberOfEven(arr);
Console.WriteLine($"-> колличество четных чисел: {even}");