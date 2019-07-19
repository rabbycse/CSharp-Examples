using System;
using System.Collections.Generic;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int>() { 1, 2, 3, 4 };
            SumLibrary library = new SumLibrary();
            Example1 eventExample = new Example1();
            eventExample.Process += new Example1.Calculate(library.SimpleSum);
            eventExample.Process += new Example1.Calculate(library.MultiSum);
            eventExample.Start(items);
        }
    }
}
