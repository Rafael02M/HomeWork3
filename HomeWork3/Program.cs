using System;

namespace Project
{
    class Program
    {
        static double diagonalsOfMatrix(int[,] matrix)
        {
            int sumOfMainDiagonal = 0, sumOfSecondaryDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumOfMainDiagonal += matrix[i, i];
                sumOfSecondaryDiagonal += matrix[i, matrix.GetLength(1) - 1 - i];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum of main diagonal: {sumOfMainDiagonal}");
            Console.WriteLine($"Sum of secondary diagonal: {sumOfSecondaryDiagonal}");

            double divOfDiagonal = (double)sumOfMainDiagonal / sumOfSecondaryDiagonal;
            return divOfDiagonal;

        }
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] matrix = new int[4, 4];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
            double diagonal = diagonalsOfMatrix(matrix);
            Console.WriteLine($"Divison of sums: {diagonal}");
        }
    }
}