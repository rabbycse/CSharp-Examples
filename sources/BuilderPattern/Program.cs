using System;
using System.Text;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //https://www.paynow.com/pay?key=3897398&secret=jkljfejfekls&type=3&amount=33&address=sflsfjd&city=dhaka&country=bangladesh&ddtype=3&nstooken=38028&date=2/2/2002&card=02832038208&cvv=382&expire=2/2/2004
            Console.WriteLine("Hello World!");

            string key = "3897398";
            string secret = "jkljfejfekls";
            double amount = 383.3;

            APIRequestBuilder builder = new APIRequestBuilder("www.paynow.com", key, secret);
            builder.SetAddress("23, mirpur, dhaka");
            builder.SetCity("Dhaka");
            builder.SetAmount(amount);

            Console.WriteLine(builder.GetUrl());
            

            string cc = "";

            Email email = new Email();
            email.From = "rabbycse7@gmail.com";
            email.To = "info@rabbicse.com";
            email.Body = "bla bla";

            if (!string.IsNullOrWhiteSpace(cc))
                email.CCAddress = cc;

            

            EmailBuilder builder = new EmailBuilder();
            builder.SetFrom("rabbycse7@gmail.com");
            builder.SetBody("Hello");

            var email = builder.GetEmail();

    */

            StringBuilder builder = new StringBuilder();
            builder.Append(33);
            builder.Append("rabbycse");
            builder.ToString();
        }
    }
}
