
namespace CSharp.ModelCore.ExtensionMethod
{
    public static class WordExtension
    {
        //Extension Method
        //Used to add new behaviours to an existing class, struct or interface without modifying, deriving or recompiling the original type.
        //A special type of static method in a static class.
        //"this" keyword is used with the first parameter and the type of the first parameter will be the extended type.
        //Called like as an instance method of the extended type.

        //When to Use Extension Method
        //An extension method is useful when you want to add new methods to a class, struct or interface within in a DLL or framework.

        //Key Points About Extension Method
        //An extension method is a special static method but it is called like an instance method.
        //An extension method having the same name and signature like as an instance method will never be called since it has low priority than the instance method.
        //An extension method couldn't override the existing instance method.

        public static int WordCount(this string str)
        {
            string[] strArray = str.Split(' ');
            int wordCount = strArray.Length;
            return wordCount;
        }
    }
}
