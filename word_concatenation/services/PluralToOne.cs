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

        public static Queue<string> getOne(string word)
        {
            Queue<string> words = new Queue<string>();
            words.Enqueue(word);
          
            for (int i = 0; i < endings.Length; i++)
            {
                words.Enqueue(word.Remove(word.Length - endings[i].Length, endings[i].Length) + endings[i]);
            }
          
            return words;
        }
    }
}
