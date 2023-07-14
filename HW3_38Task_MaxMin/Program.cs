/*
Задача 38: Задайте массив случайных вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

void FillArray(double[] array)
{
    for (int i = 0 ; i < array.Length; i++)
       {
        array[i] = new Random().NextDouble() * 200 - 100; 
        array[i] = Math.Round(array[i],1);
        Console.Write($" {array[i]} ");
    }
    
}

 double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0 ; i < array.Length; i++)
    {
        if(array[i] > max)
        max = array[i];
    }
return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0 ; i < array.Length; i++)
    {
        if(array[i] < min)
       min = array[i];
    }
return min;
}


double[] array =new double [4];
FillArray(array);
double difference = FindMax(array) - FindMin(array);
difference = Math.Round(difference,1);
Console.WriteLine($"\nThe difference between Max and Min is {difference}");



