using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork5_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number! to calculate a factorial for:");
            object n = Convert.ToInt32(Console.ReadLine());
            var thread = new Thread(new ParameterizedThreadStart(GetFactorial));
            thread.Start(n);
            Console.WriteLine("Wait for the thread to complete");
            Console.ReadLine();
            _event.Set();
            //  ------------------------------------------------------------
           
                Console.WriteLine("Enter a number to calculate the sum of the whole numbers before:");
                object n1 = Convert.ToInt32(Console.ReadLine());
                var thread2 = new Thread(new ParameterizedThreadStart(GetWholeNumber));
                thread2.Start(n1);
                Console.WriteLine("Wait for the thread to complete");
            Console.ReadLine();
            _event.Set();

        }
        public static AutoResetEvent _event = new AutoResetEvent(false);
        private static void GetFactorial(object n)
        {
            
                int n1 = (int)n;
                long k = n1;
                for (int i = n1 - 1; i >= 1; i--)
                {
                    k = k * i;
                }
                Console.WriteLine("The factorial of {0} is {1}", n1, k);
            
        }
        private static object lockObj = new object();
        private static void GetWholeNumber(object n)
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
