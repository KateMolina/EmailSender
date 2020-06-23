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
        public static AutoResetEvent _event = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            CalculationAndIOTaskClass calcIOClass = new CalculationAndIOTaskClass();
            

    // 1.
            Console.WriteLine("Enter a number! to calculate a factorial for:");
            object n = Convert.ToInt32(Console.ReadLine());
            var thread = new Thread(new ParameterizedThreadStart(calcIOClass.GetFactorial));
            thread.Start(n);
            Console.WriteLine("Wait for the thread to complete");
            Console.ReadLine();
            _event.Set();
            //  ------------------------------------------------------------
    // 2.
            Console.WriteLine("Enter a number to calculate the sum of the whole numbers before:");
            object n1 = Convert.ToInt32(Console.ReadLine());
            var thread2 = new Thread(new ParameterizedThreadStart(calcIOClass.GetWholeNumber));
            thread2.Start(n1);
            Console.WriteLine("Wait for the thread to complete");
            Console.ReadLine();
            _event.Set();
            //  ------------------------------------------------------------
    // 3. 
            calcIOClass.ReadFromCSV();

        }

    }
}
