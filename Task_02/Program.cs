// See Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101   3 -> 11  2 -> 10

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
    bool LeadingZero = true;
    foreach(int item in array)
    {
        if(item == 1)
        {
            LeadingZero = false;
        }
        if(!LeadingZero)Console.Write($"{item}");
    }
    Console.WriteLine();
}

int[] ToBinary(int num)
{
    int[] result = new int[8];
    for (int i = 7; i >= 0; i--)
    {
        result[i] = num % 2;
        num/= 2;
        if(num == 0)
        {
            break;
        }   
    }
    return result;
}

int Number = InputInt("Введите число");
int[] array = ToBinary(Number);
PrintArray(array);

