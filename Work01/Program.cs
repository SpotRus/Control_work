string[] GetUserInput()
{
    Console.Write("Укажите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Укажите {i + 1} элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr.Last()}]");
}

string[] ArrayLength3Characters(string[] arr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) j++;
    }

    string[] res = new string[j];
    j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            res[j] = arr[i];
            j++;
        }
    }
    return res;
}

string[] array = GetUserInput();
PrintArray(array);
string[] result = ArrayLength3Characters(array);
Console.Write(" -> ");
PrintArray(result);