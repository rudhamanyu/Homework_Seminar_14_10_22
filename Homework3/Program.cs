/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] GetArray(int length)
{
    Console.Write("Введите минимально возможное значение для вещественных чисел массива: ");
    double minRandom = double.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите максимально возможное значение для вещественных чисел массива: ");
    double maxRandom = double.Parse(Console.ReadLine() ?? "");
    double[] rndArray = new double[length];
    Random rnd = new Random();
   
    for (int i = 0; i < rndArray.Length; i++)
        rndArray[i] = maxRandom - ((maxRandom - minRandom) * rnd.NextDouble());        
    return rndArray;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}
//Первое значение - минимальное число массива, второе - максимальное, третье - разница максимального и минимального)
(double, double, double) DiffMinMax(double[] arr)
{
    double minNum = arr[0];
    double maxNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNum) minNum = arr[i];
        if (arr[i] > maxNum) maxNum = arr[i];
    }
    double difference = maxNum - minNum;
    return (minNum, maxNum, difference);
}

Console.Write("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine() ?? "");
double[] arr = GetArray(length);
PrintArray(arr);
(double min, double max, double diff) = DiffMinMax(arr);
Console.WriteLine($"-> {max} - {min} = {diff}");