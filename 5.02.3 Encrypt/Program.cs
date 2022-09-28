using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._02._3_Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            program();
        }

        static void program()
        {
            Console.Clear();
            string alphabet =            "abcdefghijklmnopqrstuvwxyz0123456789 ";
            string pseudoalphabet = "bcdefghijklmnopqrstuvwxyza9876543210 ";

            Console.WriteLine("Please enter a phrase, and it will be encrypted: ");
            string userInput = Console.ReadLine();
            if (userInput == "QQQ")
            {
                Environment.Exit(0);
            }

            Console.Write("Your phrase: " + "'"+ userInput + "'"+ " is now " + "'" +EncryptedPhrase(alphabet, pseudoalphabet, userInput) + "'.");
            Console.ReadLine();
            program();
        }

        static string EncryptedPhrase(string alphabet, string pseudoalphabet,string userInput)
        {
            string output = "";
            for (int i = 0; i < userInput.Length; i++)
            {
                for (int x = 0; x < alphabet.Length; x++)
                {
                    if (userInput[i].ToString().ToUpper() == alphabet[x].ToString().ToUpper())
                    {
                        output += pseudoalphabet[x];
                        break;
                    }
                    if (x == alphabet.Length - 1)
                    {
                        output += userInput[i];
                    }
                }
            }
            return output;
        }
    }
}
