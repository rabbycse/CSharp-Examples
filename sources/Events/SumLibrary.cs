using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class SumLibrary
    {
        public void SimpleSum(List<int> items)
        {
            var sum = 0;
            foreach (var item in items)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }

        public void MultiSum(List<int> items)
        {
            var multiSum = 0;
            foreach (var item in items)
            {
                multiSum += item * item;
            }
            Console.WriteLine(multiSum);
        }
    }
}
