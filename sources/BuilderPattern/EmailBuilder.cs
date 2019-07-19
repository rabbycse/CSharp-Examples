using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace BuilderPattern
{
    public class EmailBuilder
    {
        private Email email;
        public EmailBuilder()
        {
            email = new Email();
            SetPriority(1);
            SetType(2);
            SetUseSSL(true);
        }

        private bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, "");
        }

        public void SetFrom(string fromAddress)
        {
            if (IsValidEmail(fromAddress))
            {
                email.From = fromAddress;
            }
            else
                throw new InvalidOperationException("Invalid From Address, Provide valid Email");
        }

        public void SetTo(string toAddress)
        {
            if (IsValidEmail(toAddress))
            {
                email.To = toAddress;
            }
            else
                throw new InvalidOperationException("Invalid to Address, Provide valid Email");
        }

        public void SetCC(string ccAddress)
        {
            
        }

        public void SetAttachments(List<FileInfo> attachments)
        {
            if (attachments != null)
                email.Attachments = attachments;

        }

        public void SetPriority(int priority)
        {

        }

        public void SetType(int emailType)
        {

        }

        public void SetSubject(string subject)
        {

        }

        public void SetBody(string body)
        {

        }

        public void SetUsername (string username)
        {

        }

        public void SetPassword(string password)
        {

        }

        public void SetUseSSL(bool useSSL)
        {

        }

        public Email GetEmail()
        {
            return email;
        }
    }
}
