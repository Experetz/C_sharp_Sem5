/* Задайте массив заполненный случайными положительными трёхзначными
числами. Напишите программу, которая покажет количество чётных чисел 
в массиве. 
[345, 897, 568, 234] -> 2*/

void FillArray(int[] array)
{
    for (int i = 0 ; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($" {array[i]} ");
        
    }
}

int CountPosElements(int[] array)
{
    int count = 0;
    for(int i = 0 ; i < array.Length; i++)
    {
        if(array[i]%2 ==0) 
        count++;
    }
    return count;
}

int[] randArray = new int [4];
FillArray(randArray);
int result = CountPosElements(randArray);
bool isres1 = (result == 1);
Console.WriteLine(isres1 ? "\nThe is only 1 even number in array" : $"\nThere are {result} even numbers in array");