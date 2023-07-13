/* Задача 31: Задайте массив из 12 элементов, заполненный случайными 
числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна -20.*/

//Заполнение массива
void FillArray(int[] array)
{
    for (int i = 0 ; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write($" {array[i]} ");
        
    }
}

int[] nums = new int[12]; 
FillArray(nums);

//Подсчет суммы 

int sumPositive = 0;
int sumNegative = 0; 

for (int i = 0 ; i < nums.Length; i++)
{
    if (nums[i] > 0) 
    sumPositive = sumPositive + nums[i];
    if (nums[i] < 0) 
    sumNegative = sumNegative + nums[i];

}
Console.WriteLine($"\n The sum of positive numbers is {sumPositive}  "+
                    $"\n The sum of negative numbers id {sumNegative} ");