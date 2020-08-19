
namespace CSharp.ModelCore.ObjectType
{
    using System;

    class Utility
    {
        //Object Type
        //An Object is a base class for all types in C#.
        //All types i.e.predefined, user-defined, reference types and value types are inherited from Object directly or indirectly.
        //Store any type of value.
        //Need to cast value into original type to perform desired operations on the value.

        //When to Use Object Type
        //Useful when you want to store any type of value.
        //Commonly used as a method return type when your method can return multiple types of values.

        //Key Points About Object Type
        //An Object type can be passed as a method argument.
        //Also, a method can return an object type.
        //Need to cast into original type to use it and performing desired operations.

        //accepting two types of parameter:integer and string
        //returning two types of result: integer and string
        public object Add(object param1, object param2)
        {
            if (param1 is int && param2 is int)
                //need typecasting to perform add operation
                return Convert.ToInt32(param1) + Convert.ToInt32(param2);

            else if (param1 is string && param2 is string)
                //need typecasting to perform string concat operation
                return Convert.ToString(param1) + " " + Convert.ToString(param2);

            else
                return "Parameters can be either integer values or string values";
        }
    }
}
