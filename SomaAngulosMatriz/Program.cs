/*
    Crie um programa que execute as seguintes funcionalidades em uma matrix quadrada:
    A) Soma de cada linha da matriz
    B) Soma de cada coluna da matriz
    C) Soma de cada diagonal da matriz
 */

/*Functions*/

int Menu()
{
    int option;
    do
    {
        PrintLine();
        Console.WriteLine("Enter your option");
        Console.WriteLine("1- Sum of each row of the matrix");
        Console.WriteLine("2- Sum of each column of the matrix");
        Console.WriteLine("3- Sum of each diagonal of the matrix");
        Console.WriteLine("0- Exit");
        Console.Write("Your choice: ");
        option = int.Parse(Console.ReadLine());
        PrintLine();

    } while (option < 0 || option > 3);

    return option;
}

void SortMatrix(int[,] matrix, int lines, int columns)
{
    Random random = new();

    for (int l = 0; l < lines; l++)
    {
        for (int c = 0; c < columns; c++)
        {
            matrix[l, c] = random.Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix, int lines, int columns, string title)
{
    Console.WriteLine(title);
    for (int l = 0; l < lines; l++)
    {
        for (int c = 0; c < columns; c++)
        {
            Console.Write($"{matrix[l, c]} ");
        }
        Console.WriteLine();
    }
}

void SumLines(int[,] matrix, int lines, int columns)
{
    Console.WriteLine("Sum of each row of the matrix:");

    int sum = 0;
    for (int l = 0; l < lines; l++)
    {
        sum = 0;
        for (int c = 0; c < columns; c++)
        {
            sum += matrix[l, c];
        }
        Console.WriteLine($"Line[{l}] = {sum}");
    }
    PrintLine();
}

void SumColumns(int[,] matrix, int lines, int columns)
{
    Console.WriteLine("Sum of each column of the matrix:");

    int sum = 0;
    for (int l = 0; l < lines; l++)
    {
        sum = 0;
        for (int c = 0; c < columns; c++)
        {
            sum += matrix[c, l];
        }
        Console.WriteLine($"Column[{l}] = {sum}");
    }
    PrintLine();

}

void SumDiagonals(int[,] matrix, int lines, int columns)
{
    Console.WriteLine("Diagonals:");

    int sumD1 = 0, sumD2 = 0;
    for (int l = 0, c = columns - 1; l < lines; l++, c--)
    {
        sumD1 += matrix[l, l];
        sumD2 += matrix[l, c];
    }

    Console.WriteLine($"Diagonal 1 = {sumD1}");
    Console.WriteLine($"Diagonal 2 = {sumD2}");
    PrintLine();
}


void PrintLine()
{
    Console.WriteLine("=============================");
}



/*Main*/
int lines = 3, columns = 3, option;
int[,] matrix = new int[lines, columns];

do
{
    Console.Clear();
    Console.WriteLine("=====Manipulating matrixes=====");
    
    SortMatrix(matrix, lines, columns);
    PrintMatrix(matrix, lines, columns, "Matrix:");
    
    option = Menu();

    switch (option)
    {
        case 1:
            SumLines(matrix, lines, columns);
            break;
        case 2:
            SumColumns(matrix, lines, columns);
            break;
        case 3:
            SumDiagonals(matrix, lines, columns);
            break;
        case 0:
            Console.WriteLine("***End***");
            break;
        default:
            Console.WriteLine("Invalid option!");
            break;
    }
    Console.Write("\nPress any key to continue... ");
    Console.ReadKey();

} while (option != 0);
