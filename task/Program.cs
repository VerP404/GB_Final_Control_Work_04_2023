Console.Write("Введите количество элементов массива строк -> ");
int arraySize = Convert.ToInt32(Console.ReadLine());


string[] createArrayStrings = CreateArrayStrings(arraySize);
PrintArray(createArrayStrings);


string[] CreateArrayStrings(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива -> ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"“{arr[i]}”, ");
        else Console.Write($"“{arr[i]}”");
    }
    Console.Write("]");
}



