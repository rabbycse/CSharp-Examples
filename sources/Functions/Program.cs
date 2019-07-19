using System;
using System.Collections.Generic;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int>() { 1, 2, 3, 4, 5 };
            SumLibrary library = new SumLibrary();
            Example1 example = new Example1();
            example.PrintResult(items, library.SimpleSum);
        }
    }
}
