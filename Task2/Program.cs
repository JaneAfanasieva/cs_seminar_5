// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int randomSize = new Random().Next(0, 20);
int[] arr = GetRandomArray(randomSize);
PrintArray(arr);
Console.WriteLine(GetOddPosSum(arr));

int GetOddPosSum(int[] array)
{
    int result = 0;

    for(int i = 1; i < array.Length; i += 2)
    {
        result = result + array[i];
    }

    return result;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for(int i = 0; i < length; i++) 
    {
        result[i] = new Random().Next(-10, 10);
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