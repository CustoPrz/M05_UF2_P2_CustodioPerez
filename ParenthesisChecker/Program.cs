using System;

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
            bool firstandlast = FirstAndLast(response);
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
        public static bool FirstAndLast(string text)
        {
            if (text[0] == '(' && text[text.Length-1] == ')')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
