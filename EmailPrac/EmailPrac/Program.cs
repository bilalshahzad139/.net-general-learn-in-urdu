using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            String toAddress = "testemail@gmail.com";
            String subject = "Email Testing";
            String body = "Code: 123451";

            Boolean result = EmailHandler.SendEmail(toAddress, subject, body);

            if (result == false)
            {
                Console.WriteLine("Unable to send email");
            }
            else
            {
                Console.WriteLine("Email Sent!");
            }

        }
    }
}
