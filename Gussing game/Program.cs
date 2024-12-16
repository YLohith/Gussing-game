using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Gussing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;

            while(guess != secretWord && !outOfGuess)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } 
                else
                {
                    outOfGuess = true;
                }  
            }
            if (outOfGuess)
            {
                Console.WriteLine("YOU Lose!");
            }
            else
            {
                Console.WriteLine("YOU WIN!");
            }
            Console.ReadLine();
        }
    }
}
