using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Parallel
{
    class MultiplyingMatrices
    {
        //int r;
        //int c;
        //public MultiplyingMatrices(int row, int col)
        //{
        //    r = row;
        //    c = col;
        //}

        Random random = new Random();
       
        public void FillingMatrices(int[,] matrix1, int[,] matrix2)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = random.Next(0, 10);
                }
            }
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = random.Next(0, 10);
                }
            }
        }

        public int[,] Multiplication (int[,] matrix1, int[,] matrix2)
        {
           var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            Parallel.For(0, matrix1.GetLength(0), (i)=>
            {
                Console.WriteLine($"ThreadId {Task.CurrentId} has started");
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix3[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                    Console.WriteLine($"ThreadId {Task.CurrentId} completed and filled m3 with {matrix3[i,j]}");
                    }
                }
            });
            return matrix3;
        }

        public int[,] Display(int[,] matrix1)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                for (int l = 0; l < matrix1.GetLength(1); l++)
                {
                    Console.Write(matrix1[k, l] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return matrix1;
        }
    }
}
