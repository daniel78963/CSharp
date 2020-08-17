 
namespace CSharp.ModelCore.StaticClass
{
    using System;

    static class EmailClient
    {
        static string sender { get; set; }
        static EmailClient()
        {
            sender = "info@dotnettricks.com";
            Console.WriteLine("Static constructor called");
        }

        public static void SendEmail(string receiver)
        {
            // TO DO: Write code for sending email
            Console.WriteLine("Email sent to {0} from {1}", receiver, sender);
        }
    }
}
