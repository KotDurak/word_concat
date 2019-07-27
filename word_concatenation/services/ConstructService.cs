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

        public string getConstruction(string row)
        {
            // (матрас|матрац) (+кот | +Котик | +Котяра | +Котенька | +Пушистый друг | +Котейка | +Барсик | +Коток | +Усатый-полосатый | +Мышелов | +Питомец | +Любимец | +Животное | +Котище | +Котофей | +Васька | +Котишка | +Коташка | +Мурзик | +Котяга | +Хаус | +Женолюб | +Сутенер | +Бабник | +Кобель) минус 
            Hashtable collection = this.getGroups(row);
            string[] markers = this.getWords(collection["markers"].ToString());
            string[] synonims = this.trimSynonims(this.getWords(collection["synonims"].ToString()));

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
    }
}
