using System;
using System.Collections.Generic;
using System.Linq;

namespace StudioCountingCharacters
{
    class Program
    {
        static void CountCharacter(string str)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            char[] characterInString = str.ToCharArray();

            for (int i = 0; i<characterInString.Length; i ++)
            {
                if (!charCounts.Keys.Contains(Char.ToLower(characterInString[i])) && Char.IsLetter(characterInString[i]))
                {
                    int counts = 0;
                    char searchChar = Char.ToLower(characterInString[i]);
                    foreach (char character in characterInString)
                    {
                        if (Equals(Char.ToLower(character), searchChar))
                        {
                            counts += 1;
                        }
                    }
                    charCounts.Add(searchChar, counts);
                }
            }

            foreach (KeyValuePair<char, int> character in charCounts)
            {
                Console.WriteLine(character.Key + ": " + character.Value);
            }
  }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!")
            string input;
            Console.WriteLine("Please enter a string: ");
            input = Console.ReadLine();
            CountCharacter(input);
        }
    }
}
