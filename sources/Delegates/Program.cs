using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            SumLibrary library = new SumLibrary();
            List<int> items = new List<int>() { 1, 2, 3, 4 };

            Example1.Calculate calculate = new Example1.Calculate(library.SimpleSum);
            var result = calculate(items);
            Console.WriteLine(result);

            calculate = new Example1.Calculate(library.MultiSum);
            Console.WriteLine(calculate(items));
        }
    }
}
