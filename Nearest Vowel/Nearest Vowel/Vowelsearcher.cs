using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_Vowel
{
    public class Vowelsearcher
    {
        private static readonly char[] VOWELS = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        public static int[] NearestVowel(string str)
        {
            int[] result = new int[str.Length];

            for (int i = 0; i < str.Length; i++) 
            {
                char c = str[i]; 

                if (c == ' ')
                {
                    result[i] = 1;
                }
                else if (VOWELS.Contains(c))
                {
                    result[i] = 0;
                }
                else 
                {
                    int distance = 0;
                    //bool condition = true;
                    while (true)
                    {
                        if (!VOWELS.Contains(c))
                        {
                            distance++;
                        }
                        //condition = false;
                        break;
                    }
                    result[i] = distance;
                }
            }

            return result;
        }

    }
}
