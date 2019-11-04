using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_concatenation.services
{
    class PluralToOne
    {
        public static string[] endings = {"ий", "ый", "ой"};

        public static string[] getOne(string word)
        {
            string[] words = new string[endings.Length];
           
                for (int i = 0; i < endings.Length; i++)
                {
                    words[i] = word.Remove(word.Length - endings[i].Length, endings[i].Length) + endings[i];
                }
          
            return words;
        }
    }
}
