using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Parallel
{
    class Program
    {
       


        static void Main(string[] args)
        {
            int r = 5;
            int c = 5;
            int[,] matrix1 = new int[r,c];
            int[,] matrix2 = new int[r, c];
            int[,] matrix3 = new int[r, c];


            MultiplyingMatrices matr = new MultiplyingMatrices();

          
            matr.FillingMatrices(matrix1, matrix2);
           // matr.Display(matrix1);
            //matr.Display(matrix2);
            matr.Display(matr.Multiplication(matrix1, matrix2));

           





        }
    }
}
