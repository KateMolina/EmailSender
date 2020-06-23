using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace HomeWork5_Threading
{
    class CalculationAndIOTaskClass
    {
        public void ReadFromCSV()
        {
            try
            {
                FileStream fileIn = new FileStream("emails.csv", FileMode.Open, FileAccess.Read);
                FileStream fileOut = new FileStream("newfile.txt", FileMode.Create, FileAccess.Write);
                int i;
                while ((i = fileIn.ReadByte()) != -1)
                {
                    fileOut.WriteByte((byte)i);
                }
                fileIn.Close();
                fileOut.Close();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.WriteLine("Succesfully copied" );
        }


        public  void GetFactorial(object n)
        {

            int n1 = (int)n;
            long k = n1;
            for (int i = n1 - 1; i >= 1; i--)
            {
                k = k * i;
            }
            Console.WriteLine("The factorial of {0} is {1}", n1, k);

        }
       // private static object lockObj = new object();
        public  void GetWholeNumber(object n)
        {

            int n1 = (int)n;
            long k = n1;
            for (int i = n1 - 1; i > 0; i--)
            {

                k = k + i;
            }
            Console.WriteLine("The sum of the whole number{0} is {1}", n1, k);

        }


    }
}
