using System;

public class MathOperations
{
    public static object Add(object a, object b)
    {
        if (a is int && b is int)
        {
            return (int)a + (int)b;
        }
        else if (a is double && b is double)
        {
            return (double)a + (double)b;
        }
        else if (a is int[] && b is int[])
        {
            int[] array1 = (int[])a;
            int[] array2 = (int[])b;

            if (array1.Length != array2.Length)
            {
                throw new ArgumentException("Arrays must have the same length.");
            }

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }
            return result;
        }
        else if (a is double[] && b is double[])
        {
            double[] array1 = (double[])a;
            double[] array2 = (double[])b;

            if (array1.Length != array2.Length)
            {
                throw new ArgumentException("Arrays must have the same length.");
            }

            double[] result = new double[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }
            return result;
        }
        else if (a is int[,] && b is int[,])
        {
            int[,] matrix1 = (int[,])a;
            int[,] matrix2 = (int[,])b;

            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
        else if (a is double[,] && b is double[,])
        {
            double[,] matrix1 = (double[,])a;
            double[,] matrix2 = (double[,])b;

            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
        else
        {
            throw new ArgumentException("Unsupported data types.");
        }
    }
}
