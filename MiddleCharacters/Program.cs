﻿using System.ComponentModel.Design;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            MiddleString(word);
        }

        static void MiddleString(string word)
        {
            if (word.Length % 2 == 0)
            {
                Console.Write(word[word.Length / 2 - 1]);
                Console.Write(word[word.Length / 2]);
            }
            else
            {
                Console.WriteLine(word[word.Length / 2]);
            }
        }
    }
}
