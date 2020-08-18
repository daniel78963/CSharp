 
namespace CSharp.ModelCore.ExtensionMethod
{
    using System;

    public static class WordExtension
    {
        public static int WordCount(this string str)
        {
            string[] strArray = str.Split(' ');
            int wordCount = strArray.Length;
            return wordCount;
        }
    }
}
