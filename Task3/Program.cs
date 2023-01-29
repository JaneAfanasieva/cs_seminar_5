// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int randomSize = new Random().Next(0, 20);
int[] arr = GetRandomArray(randomSize);
PrintArray(arr);
Console.WriteLine(GetMaxElement(arr));
Console.WriteLine(GetMinElement(arr));
Console.WriteLine(GetMaxMinDiff(arr));

int GetMaxElement(int[] array)
{
    int max = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    } 
      
    return max;
}

int GetMinElement(int[] array)
{
    int min = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }   

    return min;
}

int GetMaxMinDiff(int[] array)
{
    return GetMaxElement(arr) - GetMinElement(arr);
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for(int i = 0; i < length; i++) 
    {
        result[i] = new Random().Next(-999, 1000);
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