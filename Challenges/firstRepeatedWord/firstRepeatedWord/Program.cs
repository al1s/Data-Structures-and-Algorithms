using System;
using System.Collections.Generic;

namespace uniqueChars
{
    class Program
    {
        public static bool UniqueChars(string sentence)
        {
            Dictionary<char, bool> chars = new Dictionary<char, bool>();
            if (sentence.Length == 0)
                return true;
            foreach (char chr in sentence.Replace(" ","").ToUpper())
            {
                if (chars.ContainsKey(chr))
                    return false;
                chars.Add(chr, true);
            }
            return true;
        }
        static void Main(string[] args)
        {
            string str = "A cat";
            Console.WriteLine($"Is all characters in '{str}' are unique: {UniqueChars(str).ToString()}");
            str = "I love cats";
            Console.WriteLine($"Is all characters in '{str}' are unique: {UniqueChars(str).ToString()}");
            Console.ReadLine();
        }
    }
}
