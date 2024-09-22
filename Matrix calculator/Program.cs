    using System;

    class Program
    {
        static void Main()
        {
            int[,] matrix1 = {
                {1, 2},
                {3, 4}
            };
            int[,] matrix2 = {
                {5, 6},
                {7, 8},
            };
        
            Console.WriteLine("Addition av matriser :");
            int[,] resultAddition = AddMatrices(matrix1, matrix2);
            PrintMatrix(resultAddition);

            Console.WriteLine("Subtraktion av matriser :");
            int[,] resultSubtraction = SubtractMatrices(matrix1, matrix2);
            PrintMatrix(resultSubtraction);

            Console.WriteLine("Multiplikation av matriser : ");
            int[,] resultMultiplication = MultiplyMatrices(matrix1, matrix2);
            PrintMatrix(resultMultiplication);
        }

        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i,j] = matrix1[i, j] + matrix2[i, j];

                }
            }
            return result;
        }

        static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength (0);
            int cols = matrix1.GetLength (1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;

        }
    
        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix2.GetLength(1);
            int common = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for(int k = 0; k < common; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

       
        }
}