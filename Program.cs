using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        public static Dictionary<string, string> MorseToAbc = new Dictionary<string, string>() {
            { ".-", "A"}, { "-...", "B"},{ "-.-.", "C"},{ "-..", "D"},
            { ".", "E"}, { "..-.", "F"}, { "--.", "G"}, { "....", "H"},
            { "..", "I"}, { ".---", "J"}, { "-.-", "K"}, { ".-..", "L"},
            { "--", "M"}, { "-.", "N"}, { "---", "O"}, { ".--.", "P"},
            { "--.-", "Q"}, { ".-.", "R"}, { "...", "S"}, { "-", "T"},
            { "..-", "U"}, { "...-", "V"}, { ".--", "W"}, { "-..-", "X"},
            { "-.--", "Y"},{ "--..", "Z"},
        };

        public static Dictionary<string, string> AbsToMorse = MorseToAbc.ToDictionary(k => k.Value, v => v.Key);


        static void Main()
        {
            string hello = "helloworld";

            string morse = ToMorse(hello);
            Console.WriteLine(morse);

            Console.WriteLine(FromMorse(morse));
        }

        static string ToMorse(string input)
        {
            input = input.ToUpper();

            string[] encoded = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                encoded[i] = AbsToMorse[input[i].ToString()];
            }

            return string.Join(" ", encoded);
        }

        static string FromMorse(string input)
        {
            string[] morse = input.Split();
            string[] decoded = new string[morse.Length];

            for (int i = 0; i < morse.Length; i++)
            {
                decoded[i] = MorseToAbc[morse[i]];
            }

            return string.Concat(decoded);
        }
    }
}
