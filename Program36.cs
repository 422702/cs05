// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = CreateArray(10);
PrintArray(array);
int sum = SumOdd(array);
Console.WriteLine($"Сумма элементов на нечетных позициях в массиве = {sum}");


void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

int SumOdd(int[] array)
{
    int sum = 0;
    for(int i=1; i<array.Length;i=i+2)
    {
        sum+=array[i];
    }
    return sum;
}