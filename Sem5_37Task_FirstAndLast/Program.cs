/* Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

void FillArray(int[] array)
{
    for (int i = 0 ; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
        Console.Write($"{array[i]} ");
        
    }
}

int[] FillNewArray(int[] array)
{
    int size;
    if(array.Length % 2 == 0) 
    {size = array.Length / 2;
    }
    else {size = array.Length/2 + 1;}

    int[] newarray = new int [size];

   for (int i = 0 ; i < array.Length/2; i++)
    {
        newarray[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length %2 != 0)
    { newarray[size-1] = array[array.Length/2];}
    return newarray;
}

int[] randArray = new int [9];
FillArray(randArray);
int[] producedarray = FillNewArray(randArray);
Console.Write($"\n New array is ");
for (int i = 0; i < producedarray.Length; i++)
        {
            Console.Write($"{producedarray[i]} ");
        }
