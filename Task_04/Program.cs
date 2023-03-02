// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int InputInt(string msg)
{
    Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] Array(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach(int item in array)
    {
        Console.WriteLine($"{item}");
    }
    Console.WriteLine();
}

int[] Copy(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

int size = InputInt("Введите число");
int[] array = Array(size);
Console.WriteLine("Исходный массив");
PrintArray(array);
int[] array2 = array;
array[0] = 999;
Console.WriteLine("Массив 2 после изменения первого массива");
PrintArray(array2);
int[] array3 = Copy(array);
array[3] = 111;
Console.WriteLine("Массив 3 после изменения первого массива");
PrintArray(array3);
Console.WriteLine("Измененный исходный массив");
PrintArray(array);