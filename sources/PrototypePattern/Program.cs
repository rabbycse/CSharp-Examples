using BuilderPattern;
using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Username = "rabbycse";


            Email email2 = email.Clone();
            Email email3 = email.Clone();

            email2.Username = "rabbi";
        }
    }
}
