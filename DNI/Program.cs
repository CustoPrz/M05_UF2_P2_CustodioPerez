using System;
using System.Text;

namespace DNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your DNI/NIF number (Without the letter):");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your complete DNI/NIF is: " + number + LetterNIF(number));
        }

        /// <summary>
        /// This 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static char LetterNIF(int number)
        {
            int lettersPos;
            string letters = "TRWAGMYFPDXBNJZSQVHLCKE";
            lettersPos = number % 23;
            return letters[lettersPos];
        }
    }
}
