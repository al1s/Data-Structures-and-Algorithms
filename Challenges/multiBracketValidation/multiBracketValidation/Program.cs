using System;
using Stack_and_Queue.Classes;

namespace multiBracketValidation
{
    public class Program
    {
        /// <summary>
        /// Check whether the brackets in an input string are balanced
        /// </summary>
        /// <param name="input">String to be checked for having balanced brackets</param>
        /// <returns>true - if brackets are balanced, false - otherwise</returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack stack = new Stack(new Node(null));
            stack.Pop();
            Node temp = default(Node);
            char[] inpArr = input.ToCharArray();
            for (int i = 0; i < inpArr.Length; i++)
            {
                switch (inpArr[i])
                {
                    case '{':
                        stack.Push(new Node('}'));
                        break;
                    case '[':
                        stack.Push(new Node(']'));
                        break;
                    case '(':
                        stack.Push(new Node(')'));
                        break;
                    default:
                        break;
                }
                if (inpArr[i] == '}' || inpArr[i] == ']' || inpArr[i] == ')')
                {
                    if (stack.Peek() == null)
                        return false;
                    temp = stack.Pop();
                    if ((char)temp.Value != inpArr[i])
                        return false;
                }
            }
            if (stack.Peek() != null) return false;
            return true;
        }
        static void Main(string[] args)
        {
            string inp = "{[()]}";
            Console.WriteLine($"Are brackets in \"{inp}\" balanced: {MultiBracketValidation(inp).ToString()}");
            inp = "{[)(]}";
            Console.WriteLine($"Are brackets in \"{inp}\" balanced: {MultiBracketValidation(inp).ToString()}");
            inp = "{";
            Console.WriteLine($"Are brackets in \"{inp}\" balanced: {MultiBracketValidation(inp).ToString()}");
            inp = ")";
            Console.WriteLine($"Are brackets in \"{inp}\" balanced: {MultiBracketValidation(inp).ToString()}");
            inp = "if (stack.Peek() != null) return false;";
            Console.WriteLine($"Are brackets in \"{inp}\" balanced: {MultiBracketValidation(inp).ToString()}");
            Console.ReadLine();
        }
    }
}
