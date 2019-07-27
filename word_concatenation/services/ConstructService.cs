using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace word_concatenation.services
{
    class ConstructService
    {
        private char[] trims = {'(',')'};

        public const int ITERATION_COUNT = 6;

        public string getConstruction(string row)
        {
            // (матрас|матрац) (+кот | +Котик | +Котяра | +Котенька | +Пушистый друг | +Котейка | +Барсик | +Коток | +Усатый-полосатый | +Мышелов | +Питомец | +Любимец | +Животное | +Котище | +Котофей | +Васька | +Котишка | +Коташка | +Мурзик | +Котяга | +Хаус | +Женолюб | +Сутенер | +Бабник | +Кобель) минус 
            Hashtable collection = this.getGroups(row);
            if (collection.Count == 0)
            {
                return "";
            }
            string[] markers =  this.getWords(collection["markers"].ToString());
            string[] synonims = this.trimSynonims(this.getWords(collection["synonims"].ToString()));

            List<string> lines = this.getAllWariant(markers, synonims, collection["minus"].ToString());

            return row;
        }

        private Hashtable getGroups(string row)
        {
            Hashtable elements = new Hashtable();
            string pattern = @"(\([а-яА-Я\s\|]+\))\s(\(.+\))(.*)";
            MatchCollection collection =  Regex.Matches(row, pattern, RegexOptions.IgnoreCase);

            foreach (Match col in collection)
            {
                elements.Add("markers", col.Groups[1].Value);
                elements.Add("synonims", col.Groups[2].Value);
                elements.Add("minus", col.Groups[3].Value);
            }
            

            return elements;
        }

        private string[] getWords(string words)
        {
            string trim_words = words.Trim(this.trims);
            return trim_words.Split(new char[] { '|' });
        }

        private string[] trimSynonims(string[] synonims)
        {
            for(int i = 0; i < synonims.Length; i++)
            {
                synonims[i] = synonims[i].Trim().Trim(new char[] { '+'});
            }
            return synonims;
        }

        private string getConcatWords(string marker, string synonim, string minus_words, int count_marker = 1)
        {
            string row = String.Concat(Enumerable.Repeat(marker + ' ', count_marker));
            row += synonim;
            row += minus_words;
            return row;
        }

        private List<string> getAllWariant(string[] markers, string[] synonims, string minus_words)
        {
            string[] result = new string[markers.Length * synonims.Length * ConstructService.ITERATION_COUNT];
            List<string> lines = new List<string>();

            for (int i = 0; i < markers.Length; i++)
            {
                for(int j = 0; j < synonims.Length; j++)
                {
                    for(int k = 1; k <= ConstructService.ITERATION_COUNT; k++)
                    {
                        lines.Add(this.getConcatWords(markers[i], synonims[j], minus_words, k));
                    }
                }
            }

            return lines;
        }
    }
}
