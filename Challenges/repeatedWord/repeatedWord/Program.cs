using System;
using System.Collections.Generic;

namespace repeatedWord
{

    public class Program
    {
        /// <summary>
        /// Given a text return a first repeated word (case-insencitive)
        /// </summary>
        /// <param name="text">Text to check for repeated words</param>
        /// <returns>The first word which was repeated</returns>
        public static string RepeatedWord(string text)
        {
            if (text.Length == 0) return string.Empty;
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            string[] textArr = text.ToLower().Split(" ");
            foreach (string word in textArr)
            {
                if (dict.ContainsKey(word))
                    return word;
                dict.Add(word, true);
            }
            return string.Empty;
        }
        public static void Main(string[] args)
        {
            string text = "A fox is a fox";
            Console.WriteLine($"{text} : {RepeatedWord(text)}");
            text = "A";
            Console.WriteLine($"{text} : {RepeatedWord(text)}");
            text = "";
            Console.WriteLine($"{text} : {RepeatedWord(text)}");
            Console.ReadLine();
        }
    }
}
