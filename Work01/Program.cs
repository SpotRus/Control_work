string[] GetUserInput()
{
    Console.WriteLine("Укажите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Укажите {i + 1} элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}


string[] array = GetUserInput();

