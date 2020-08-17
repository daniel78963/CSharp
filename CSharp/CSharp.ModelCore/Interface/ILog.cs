
namespace CSharp.ModelCore.Interface
{
    interface ILog
    {
        void Log(string msg);

        //Interface
        //An interface acts as a contract for a class or structure which implements it.
        //A class or structure that implements an interface is bound to implements all its members.
        //Interface never acts as a parent just like an abstract class.
        //An interface has only members declaration and implicitly every member of an interface is public and abstract.

        //Interface Example
        //Suppose you want to create a logger library for logging the error messages into database, text file or into the console.To achieve this functionality, you need to create a separate class for each type of logging.
    }
}
