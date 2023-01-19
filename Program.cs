void Array()
{
    int rows = 3;
    int columns = 5;

    object[,] symbols = new object[rows, columns];

    FillArray(symbols);
    Console.WriteLine("Ваш массив");
    OutputArr(symbols);
    Console.WriteLine("Новый массив");
    NewArray(symbols);
}

void FillArray(object[,] symbols)
{
    int rows = symbols.GetLength(0);
    int columns = symbols.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine($"Строка № {i + 1}");
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine ("Enter symbols");
            symbols[i, j] = Console.ReadLine();
        }
    }
    
}

void OutputArr(object[,] symbols)
{
    int rows = symbols.GetLength(0);
    int columns = symbols.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(symbols[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void NewArray(object[,] symbols)
{
    Random rand = new Random();
    int rows = symbols.GetLength(0);
    int columns = rand.Next(0, 4);
    for (int i = 0; i < rows; i++)
    {
        for (int p = 0; p < columns; p++)
        {
            Console.Write(symbols[i, rand.Next(0, 4)] + "  ");
        }
        Console.WriteLine();
    }
}

Array();