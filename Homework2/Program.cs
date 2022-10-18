/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int length)
{
    int[] rndArray = new int[length];
    Console.Write("Введите минимальное значение для случайных чисел массива: ");
    int min = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите максимальное значение для случайных чисел массива: ");
    int max = int.Parse(Console.ReadLine() ?? "");
    Random rnd = new Random();

    for (int i = 0; i < rndArray.Length; i++)
        rndArray[i] = rnd.Next(min, max);
    return rndArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int GetSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (i % 2 == 0)
            sum += arr[i];
    return sum;
}

Console.Write("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine() ?? "");
int[] arr = GetArray(length);
PrintArray(arr);
int sum = GetSum(arr);
Console.WriteLine($"-> сумма элементов нечетных позиций: {sum}");