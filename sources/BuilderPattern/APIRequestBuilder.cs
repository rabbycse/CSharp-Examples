using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class APIRequestBuilder
    {
        private string requestUrl = "";
        public APIRequestBuilder(string domain, string key, string secret)
        {
            requestUrl += "https://" + domain + "?key=" + key + "&serect=" + secret;
        }

        public void SetAmount(double amount)
        {
            requestUrl += "&amount=" + amount;
        }

        public void SetAddress(string address)
        {
            requestUrl += "&address=" + address;
        }

        public void SetCity(string city)
        {
            requestUrl += "&city=" + city;
        }

        public string GetUrl()
        {
            return requestUrl;
        }
    }
}
