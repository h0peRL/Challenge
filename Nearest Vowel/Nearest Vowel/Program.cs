using System;

namespace Nearest_Vowel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eingabe Bitte");
        string input = Console.ReadLine();
        int[] output = Vowelsearcher.NearestVowel(input);

        for (int i = 0; i < output.Length; i++)
        {
            Console.Write(output[i] + ", ");
            
        }

    }
}