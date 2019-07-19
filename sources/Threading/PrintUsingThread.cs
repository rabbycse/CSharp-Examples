using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    public class PrintUsingThread
    {
        public void threadA()
        {
            for (int z = 0; z < 20; z++)
            {
                Console.WriteLine("Printing from thread 1");
                Thread.Sleep(100);
            }
        }

        public void threadB()
        {
            for (int z = 0; z < 20; z++)
            {
                Console.WriteLine("Printing from thread 2");
                Thread.Sleep(100);
            }
        }

        public static void thread1()
        {
            for (int z = 0; z < 20; z++)
            {
                Console.WriteLine("Printing from thread 1");
                Thread.Sleep(100);
            }
        }

        // static method for thread b 
        public static void thread2()
        {
            for (int z = 0; z < 20; z++)
            {
                Console.WriteLine("Printing from thread 2");
                Thread.Sleep(100);
            }
        }
    }
}
