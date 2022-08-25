// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int size = 5;
int[] array = new int[size];
int sum = 0;
FillRandom(array);
PrintArray(array);

for(int i = 1; i < array.Length; i = i + 2)
{
    sum = array[i] + sum;
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
void FillRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
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
