using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Disemvoweler with all of the required phrases
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");

            // keep the console open
            Console.ReadKey();
        }
        static void Disemvoweler(string input)
        {
            // Declare StringBuilders to hold the appended strings as they are created
            StringBuilder leftOver = new StringBuilder();
            StringBuilder vowels = new StringBuilder();

            // Iterate over each character of the string input
            for (int i = 0; i < input.Length; i++)
            {
                // Test the character if it's a vowel or consonant, don't include special characters
                if ("aeiou".Contains(input[i].ToString().ToLower()))
                {   // Contains a vowel
                    // Add to the vowel string
                    vowels.Append(input[i]);
                }
                else if ("bcdfghjklmnpqrstvwxyz".Contains(input[i].ToString().ToLower()))
                {
                    // only need consonants, not special characters
                    // add to the leftOver string for the consonants
                    leftOver.Append(input[i]);
                }
            }
            
            // Write out the various string results
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + leftOver.ToString());
            Console.WriteLine("Vowels Removed: " + vowels.ToString() + "\n"); // Included newline between different calls
        }
    }
}
