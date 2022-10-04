// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine($"Введите массив вещественных чисел:");
double[] array=CreateArray();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {CalculatingDifference(array)}");


double[] CreateArray()
{
    string[] text = Console.ReadLine().Split(" ");
    double[] array = new double[text.Length];
    for (int i = 0; i < text.Length; i++)
    {
         array[i] = double.Parse(text[i]);
    }
    return array;
}

double CalculatingDifference(double[] array)
{
    double max=array[0],min=array[0];
    for(int i=1;i<array.Length;i++)
    {
        if(max<array[i]) max=array[i];
        if(min>array[i]) min=array[i];
    }
 return max-min;
}