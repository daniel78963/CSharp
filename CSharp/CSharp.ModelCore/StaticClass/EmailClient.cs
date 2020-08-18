
namespace CSharp.ModelCore.StaticClass
{
    using System;

    static class EmailClient
    { 
        //Static Class
        //The static keyword is used to create a static class.
        //Cannot be instantiated; since it is loaded into memory automatically by the CLR at the time of code execution.
        //Static class members are called only with the class name.
        //In the memory, only one copy of the static member exists and shared by all the instances of a class.
        //Static Members
        //Static class members (method, field, property, or event) are declared using the static keyword.These can be called only with the class name. In the memory, only one copy of static member exists and which is shared by all the instances of a class.

        //When to Use Static Class
        //A static class is useful when you want to provide some common utilities like various configuration settings, driver manipulation etc.to your application

        //Key Points About Static Class
        //A static class contains only static members.
        //A static class cannot be instantiated.
        //A static class is sealed, hence cannot be inherited.
        //A static class can have only one static constructor that can be default constructor with private access modifier and used to initialize static members.
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
