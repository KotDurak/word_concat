using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using word_concatenation.services;

namespace word_concatenation
{
     class SynomymsParse
    {
        public static string GetWord(string word, bool toOne)
        {

            try
            {
                string ending = word.Substring(word.Length - 2);

                string result = "";

                bool isPlural = ending == "ие" || ending == "ые";
                if (isPlural && toOne)
                {
                    string[] wordsArray = PluralToOne.getOne(word);
                    string synonimsLine = "";
                    foreach(string w in wordsArray)
                    {
                        try
                        {
                            string href = @"https://text.ru/synonym/" + w;
                            var pc = SynomymsParse.LoadPage(href);
                            var doc = new HtmlDocument();
                            doc.LoadHtml(pc);
                            HtmlNodeCollection wds = doc.DocumentNode.SelectNodes("//table[@id='table_list_synonym']//td[@class='ta-l']/a");
                            int j = 0;
                            foreach (HtmlNode elem in wds)
                            {
                                j++;
                                synonimsLine += " +" + elem.InnerText + " |"; 
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    if (synonimsLine.Length != 0)
                    {
                        synonimsLine = synonimsLine.Trim('|');
                        return "(+" + word + " |" + synonimsLine;
                    }
                }

                word = word.Trim();
                string url = @"https://text.ru/synonym/" + word;
                var pageContent = SynomymsParse.LoadPage(url);
                var document = new HtmlDocument();
                document.LoadHtml(pageContent);
                HtmlNodeCollection words = document.DocumentNode.SelectNodes("//table[@id='table_list_synonym']//td[@class='ta-l']/a");
                // HtmlNode tableNode = document.DocumentNode.SelectSingleNode("//table[@id='table_list_synonym']");
                if (words == null)
                {
                    return "(+" + word + ")";
                }
                result += "(+" + word + " |";
                int i = 0;
                foreach (HtmlNode elem in words)
                {
                    i++;
                    if (i != words.Count)
                    {
                        result += " +" + elem.InnerText + " |";
                    }
                    else
                    {
                        result += " +" + elem.InnerText;
                    }
                }
                result += ")";
                return result;
            } 
            catch(Exception)
            {
                return "(" + word + ")";
            }
         
            
            
        }

        static string LoadPage(string url)
        {
            var result = "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse(); 
            if(response.StatusCode == HttpStatusCode.OK)
            {
                var receiveStream = response.GetResponseStream();
                if(receiveStream != null)
                {
                    StreamReader readStream;
                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }
                    result = readStream.ReadToEnd();
                    readStream.Close();
                }
                response.Close();
            }
            return result;
        }
    }
}
