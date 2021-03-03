using System;

namespace A_String_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine();
            var output = "";

            for (var i = 0; i < words.Length; i++)
            {
                if (!isVowel(words[i]))
                {
                    output += ".";
                    var ch = words[i];

                    if (char.IsUpper(ch))
                    {
                        ch = char.ToLower(ch);
                    }
                    output += ch;
                }
            }
            Console.WriteLine(output);
        }

        static bool isVowel(char letter)
        {
            if (char.IsUpper(letter))
            {
                letter = char.ToLower(letter);
            }
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'y') 
            {
                return true;
            }
            return false;
        }
    }
}
