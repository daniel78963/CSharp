
namespace CSharp.ModelCore.ObjectType
{
    using System;

    class Utility
    {
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
