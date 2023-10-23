using System;
                                 //Це типу для тесту створив
class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 7;
        double x = 3.5;
        double y = 2.0;
        int[] intArray1 = { 1, 2, 3 };
        int[] intArray2 = { 4, 5, 6 };
        double[] doubleArray1 = { 1.1, 2.2, 3.3 };
        double[] doubleArray2 = { 4.4, 5.5, 6.6 };
        int[,] intMatrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] intMatrix2 = { { 5, 6 }, { 7, 8 } };
        double[,] doubleMatrix1 = { { 1.1, 2.2 }, { 3.3, 4.4 } };
        double[,] doubleMatrix2 = { { 5.5, 6.6 }, { 7.7, 8.8 } };

        object result1 = MathOperations.Add(a, b);
        object result2 = MathOperations.Add(x, y);
        object result3 = MathOperations.Add(intArray1, intArray2);
        object result4 = MathOperations.Add(doubleArray1, doubleArray2);
        object result5 = MathOperations.Add(intMatrix1, intMatrix2);
        object result6 = MathOperations.Add(doubleMatrix1, doubleMatrix2);

        Console.WriteLine($"Add int: {result1}");
        Console.WriteLine($"Add double: {result2}");
        Console.WriteLine($"Add int array: [{string.Join(", ", (int[])result3)}]");
        Console.WriteLine($"Add double array: [{string.Join(", ", (double[])result4)}]");
        Console.WriteLine($"Add int matrix:");
        PrintMatrix((int[,])result5);
        Console.WriteLine($"Add double matrix:");
        PrintMatrix((double[,])result6);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
