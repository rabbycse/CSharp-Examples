using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class Example1
    {
        public delegate void Calculate(List<int> items);

        public event Calculate Process;

        internal void Start(List<int> items)
        {
            Process(items);
        }
    }
}
