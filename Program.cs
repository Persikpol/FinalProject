﻿void Array()
{
    int rows = 3;
    int columns = 4;

    object[,] symbols = new object[rows, columns];

    FillArray(symbols);
    
}

void FillArray(object[,] symbols)
{
    int rows = symbols.GetLength(0);
    int columns = symbols.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine ("Enter symbols");
            symbols[i, j] = Console.ReadLine();
            
            
        }
        
    }
    
}

Array();