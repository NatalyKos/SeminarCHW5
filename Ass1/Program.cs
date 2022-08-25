// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int size = 5;
int[] array = new int[size];
int sum = 0;
FillRandom(array);
PrintArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве равно {sum}");
void FillRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}