
namespace CSharp.ModelCore.ExtensionMethod
{
    using System;

    //Partial Class
    //A Partial class, interface and structure were introduced in C# 2.0. Now, it is possible to split the definition of a class, interface or structure over more than one source files. These source files must be defined in the same namespace or assembly and must have the partial keyword and same access modifiers.
    //The above two partial classes would be combined into one at compile time as given 

    //When to use Partial
    //Allow more than one developer to work simultaneously on the same class, struct or interface.
    //Partial class are particularly helpful for customizing auto-generated code by the IDE.Whenever the IDE generate the code then the tool may define some partial class, interface, methods and further customization of a partial class, the interface is done by the developers without messing with the system generated code.

    //Key Points about Partial
    //During code compilation, all the files should be available to form the final class, interface or struct.
    //Any member declared in the one part/file will be available to all other parts.
    //If any part has Inheritance, then it applies to the entire class.
    //Different parts of a class or struct may inherit from different interfaces.
    //If any part is declared abstract, then the whole class, interface or struct is considered abstract.
    //If any part is declared sealed, then the whole class, interface or struct is considered sealed.

    // Partial Class Part1
    partial class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }


    // Partial Class Part2
    partial class Calculator
    {
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
