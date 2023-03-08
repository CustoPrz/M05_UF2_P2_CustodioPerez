using System;
using System.Collections.Generic;

namespace ParenthesisChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text with parenthesis");
            string response = Console.ReadLine();
            int open = CountChars(response, '(');
            int close = CountChars(response, ')');
            bool firstandlast = Valid(response);
            if(open == close && firstandlast)
            {
                Console.WriteLine("The parenthesis close");
            }
            else
            {
                Console.WriteLine("The parenthesis don't close");
            }
        }
        public static int CountChars(string text, char search)
        {
            int amount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] != search)
                    amount++;
            }
            return amount;
        }
        public static bool Valid(string text)
        {
            Stack<char> stack = new Stack<char>();
        
            foreach (char c in text)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char last = stack.Pop();
                    if (c == ')' && last != '(')
                    {
                        return false;
                    }


                }
            }
            return stack.Count == 0;
        }
    }
}
