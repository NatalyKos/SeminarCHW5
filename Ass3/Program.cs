// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76
int size = 5;
double[] array = new double[size];
int max = 0;
int min = 0;
FillRandom(array);
PrintArray(array);

for(int i = 1; i < array.Length; i++)
{
    if(array[i] > array[max])
    {
        max = i;
    }
    else
    {if(array[i] < array[min])
    {
        min = i;
    }
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {array[max] - array[min]}");
void FillRandom(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 99);
    }
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
