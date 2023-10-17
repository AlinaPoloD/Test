void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ",");

    }
    Console.Write($"{array[array.Length - 1]}]");
}

int CountElement()
{
    Console.WriteLine($"Введите, сколько элементов массива вы хотите ввести:");
    int length = Convert.ToInt32(Console.ReadLine()!);
    while (length == 0)
    {
        Console.WriteLine($"Количество элементов массива должно быть больше 0");
        Console.WriteLine($"Введите, сколько элементов массива вы хотите ввести:");
        length = Convert.ToInt32(Console.ReadLine()!);


    }
    return length;
}



string[] GenerateMassive(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} - ого элемента");
        array[i] = Console.ReadLine();
        if (i == array.Length - 1)
        {
            Console.WriteLine($"Массив заполнен");
        }
    }
    return array;
}

int CountTrueElement(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] GenerateNewArray(int length, string[] array)
{
    string[] newArray = new string[length];
    int j = 0;

    foreach (string i in array)
    {
        if (i.Length <= 3)
        {
            newArray[j] = i;
            j++;
        }
    }

    return newArray;
}




int length = CountElement();
string[] array = GenerateMassive(length);
Console.Write($"Изначальный массив -> ");
PrintArray(array);
Console.WriteLine();
int newLengthArray = CountTrueElement(array);

if (newLengthArray == 0)
{
    Console.Write($"В массиве длина любой строки больше 3");
}
else
{
    string[] newArray = GenerateNewArray(newLengthArray, array);
    Console.Write($"Получившийся массив -> ");
    PrintArray(newArray);
}






