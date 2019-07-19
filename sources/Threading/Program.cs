using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Thread a = new Thread(PrintUsingThread.thread1);
            Thread b = new Thread(PrintUsingThread.thread2);
            a.Start();
            b.Start();
            */

            PrintUsingThread obj = new PrintUsingThread();

            Thread thr1 = new Thread(new ThreadStart(obj.threadA));
            thr1.Start();

            Thread thr2 = new Thread(new ThreadStart(obj.threadB));
            thr2.Start();
        }
    }
}
