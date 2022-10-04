// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

int[] array = CreateArray(10);
PrintArray(array);
int evenNum = EvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {evenNum}");


void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length;i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}