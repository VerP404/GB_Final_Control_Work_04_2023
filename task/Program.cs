Console.Write("Введите количество элементов массива строк -> ");
int arraySize = Convert.ToInt32(Console.ReadLine());


string[] createArrayStrings = CreateArrayStrings(arraySize);
PrintArray(createArrayStrings);
int sizeNewArray = SizeNewArray(createArrayStrings, 3);
string[] newArrayStringsLessThanOrEqual = NewArrayStringsLessThanOrEqual(createArrayStrings, sizeNewArray);
Console.Write(" -> ");
PrintArray(newArrayStringsLessThanOrEqual);


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

int SizeNewArray(string[] str, int numberCharacters)
{
    int sizeArr = 0;
    for (int i = 0; i < str.Length; i++)
    {
        int count = 0;
        for (int y = 0; y < str[i].Length; y++)
        {
            count++;
        }
        if (count <= numberCharacters)
        {
            sizeArr++;
        }
    }
    return sizeArr;

}

string[] NewArrayStringsLessThanOrEqual(string[] str, int sizeArr)
{
    string[] arr = new string[sizeArr];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        int count = 0;
        for (int y = 0; y < str[i].Length; y++)
        {
            count++;
        }
        if (count <= 3)
        {
            arr[j] = str[i];
            j++;
        }
    }
    return arr;
}