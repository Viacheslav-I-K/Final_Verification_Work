// Console.Write("Введите количество строк в 2D массиве: ");
// int sizeRows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов в 2D массиве: ");
// int sizeColumns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное число элемента массива: ");
// int minNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное число элемента массива: ");
// int maxNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] matrix2D = CreaterMatrixRndInt(sizeRows, sizeColumns, minNumber, maxNumber);
// PrintMatrix(matrix2D);

// Console.WriteLine();

// int[] minIndex = MinMatrixInd(matrix2D);
// Console.Write("Минимальное число = " + matrix2D[minIndex[0], minIndex[1]]);

// Console.WriteLine();

// int[,] resuleMatrix = DeleteMinRowsColumn(matrix2D, minIndex);
// PrintMatrix(resuleMatrix);





// int[] MinMatrixInd(int[,] matrix)
// {
//     int[] resultindex = {0, 0};
//     int minValue = matrix[0, 0];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < minValue)
//             {
//                 minValue = matrix[i, j];
//                 resultindex[0] = i;
//                 resultindex[1] = j;
//             }
//         }
//     }
//     return resultindex;
// }

// int[,] CreaterMatrixRndInt(int rows, int columns, int min, int max)
// {
//     Random rnd = new Random();
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
//             else Console.Write($"{matrix[i, j], 4} ");
//         }
//         Console.WriteLine("|");
//     }
// }

// int[,] DeleteMinRowsColumn(int[,] matrix, int[] minIndex)
// {
//     int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
//     int i1 = 0;
//     int j1 = 0;
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
        
//         if (i1 == minIndex[0])i1++;
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             if (j1 == minIndex[1])j1++;
//             result[i,j] = matrix[i1,j1];
//             j1++;
//         }
//         i1++;
//         j1 = 0;
//     }
//     return result;
// }

/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/



Console.Write("Введите колличество элементов в массиве строк: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

string[] fillArray = FillArray(sizeArray);
PrintArray(fillArray);
Console.WriteLine();

string[] arrayCountingChar = CountingChar(fillArray);
Console.Write("Итоговый массив: ");
PrintArray(arrayCountingChar);

string[] CountingChar(string[] arr) // Метод для определения элементов массива подходящих под условия задания
{

    int sizeNewArr = 0;

    for (int i = 0; i < arr.Length; i++) // Определяем сколько элементов массива имеют размер меньше или равный 3, для задания размера нового массива
    {
        if (arr[i].Length <= 3)
        sizeNewArr++;
    }

    if (sizeNewArr != 0)
    {
        string[] newArrayStr = new string[sizeNewArr];
        int countIndex = 0;

        for (int k = 0; k < arr.Length; k++)
        {
            if (arr[k].Length <= 3)
            {
            newArrayStr[countIndex] = arr[k];
            countIndex++;
            }
        }
        return newArrayStr;
    }

    else
    {
        string[] newArrayStr = {"В массиве нет строк, длина которых меньше или равна 3 символа"};
        return newArrayStr;
    }
}

string[] FillArray(int size)    // Метод для заполнения массива
{
    string[] ArrayStr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        ArrayStr[i] = Console.ReadLine();
    }
    return ArrayStr;
}

void PrintArray(string[] arr)   // Метод для вывода массива в консоль
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"\"{arr[i]}\"");
        
        if (i != arr.Length - 1)
        Console.Write($", ");
    }
    Console.Write("]");
}

