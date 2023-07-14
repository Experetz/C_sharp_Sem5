/* Задача 33: Задайте массив. Напишите программу, которая определяет,
 присутствует ли заданное число в массиве.
 4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

//Methods
void FillArray(int[] array)
{
    for (int i = 0 ; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write($" {array[i]} ");
        
    }
}

bool IsFound(int[] array, int find)
{
        for (int i = 0 ; i < array.Length; i++)
    {
        if(array[i] == find) 
        {
            return true;
            
        }
    }
    return false;
}
    

int[] randArray = new int [10];
FillArray(randArray);
Console.WriteLine("\nPlease put a number your want to find ");
int usernumber = int.Parse(Console.ReadLine());
bool found = IsFound(randArray, usernumber);
 Console.WriteLine(found ? $"Yes, there is {usernumber} in array" : $"No, there id NO {usernumber} in array ");



