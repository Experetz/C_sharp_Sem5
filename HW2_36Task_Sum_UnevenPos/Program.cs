﻿/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void FillArray(int[] array)
{
    for (int i = 0 ; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]} ");
        
    }
}

int SumOfElements(int[] array)
{
    int sum = 0;
    for(int i = 0 ; i < array.Length; i++)
    {
        if(i% 2 !=0) 
        sum = sum+array[i];
    }
    return sum;
}

int[] randomarray = new int [6];
FillArray(randomarray);
Console.WriteLine($"\nThe sum of elements on uneven positions is {SumOfElements(randomarray)}");

