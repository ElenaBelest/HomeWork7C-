Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("47) Задача 47: Задайте двумерный массив размером m n, заполненный случайными вещественными числами");
        Console.WriteLine("50) Задача 50:  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        Console.WriteLine("52) Задача 52: Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 47: GetDoubleArray(); break;
            case 50: NumberOfArray(); break;
            case 52: AverageColumns(); break;
            default: Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void GetDoubleArray()
{
    Console.Clear();

    Console.Write("Enter number of rows:\t");
    int row = int.Parse(Console.ReadLine());

    Console.Write("Enter number of columns:\t");
    int column = int.Parse(Console.ReadLine());

    double [,] array = new double [row, column];

    for (int i = 0; i  < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void NumberOfArray()
{
    Console.Clear();

    Console.Write("Enter number of rows: \t");

    int row = int.Parse(Console.ReadLine());

    Console.Write("Enter number of columns:\t");
    int column = int.Parse(Console.ReadLine());

    int [,] Array = new int [5,5];

    GetRandomArray(Array);
    PrintArray(Array);


    if (row > Array.GetLength(0) && column > Array.GetLength(1))
    {
        Console.WriteLine("No number of array ");
    }
    else
    {
        Console.WriteLine($"Number of array  {Array[row-1, column-1]}");
    }

}

void GetRandomArray(int [,] array)
{
    for (int rows = 0; rows  < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows,columns] = new Random().Next(0,100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write(" ");
        Console.WriteLine(); 
    }
}
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

void AverageColumns()
{
    Console.Clear();

    Console.Write("Enter row: \t");
    int row = int.Parse(Console.ReadLine());

    Console.Write("Enter column:\t");
    int column = int.Parse(Console.ReadLine());

    int [,] array = new int[row,column];

    for (int i = 0; i  < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }

    PrintArray(array);

    Console.Write("Average of the sum of columns: ");

    for (int j = 0; j < array.GetLength(1); j++)
    {
         double average = 0;
         for (int i = 0; i < array.GetLength(0);i++)
         {
            average = average + array[i,j];
         }
         Console.Write($"{average / array.GetLength(0)} ");
         Console.Write("; ");
    }
}
