using System;
using System.Threading;

namespace DotNetTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //ThreadStart obj = new ThreadStart(DisplayNumbers);
            //Thread t1 = new Thread(obj);
            Thread t1 = new Thread(new ParameterizedThreadStart(DisplayNumbers));
            t1.Start(5);
            Console.ReadKey(true);
        }

        static void DisplayNumbers(object max)
        {
            for (int i = 1; i <= Convert.ToInt32(max); i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }
    }
}
