// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int randomSize = new Random().Next(0, 20);
int[] arr = GetRandomArray(randomSize);
PrintArray(arr);
Console.WriteLine(GetEvenNumberCount(arr));

int GetEvenNumberCount(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;   
        }
    }

    return count;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for(int i = 0; i < length; i++) 
    {
        result[i] = new Random().Next(100, 1000);
    }

    return result;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    int lastItemIndex = arr.Length - 1;

    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        
        if(i < lastItemIndex)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}