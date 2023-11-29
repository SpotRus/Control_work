using System.Data;

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
    Console.WriteLine($"{arr.Last()}]");
}

string[] array = GetUserInput();
PrintArray(array);

