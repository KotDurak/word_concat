using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Threading;

namespace word_concatenation
{
     class SynomymsParse
    {
        public static string GetWord(string word)
        {
            try
            {
                string result = "";
                word = word.Trim();
                string url = @"https://text.ru/synonym/" + word;
                var pageContent = SynomymsParse.LoadPage(url);
                var document = new HtmlDocument();
                document.LoadHtml(pageContent);
                HtmlNodeCollection words = document.DocumentNode.SelectNodes("//table[@id='table_list_synonym']//td[@class='ta-l']/a");
                // HtmlNode tableNode = document.DocumentNode.SelectSingleNode("//table[@id='table_list_synonym']");
                if (words == null)
                {
                    return "";
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
            catch (Exception)
            {
                return "";
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
