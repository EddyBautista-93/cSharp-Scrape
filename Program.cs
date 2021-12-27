using System;
using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
/*
    Packages used 
    HtmlAgilityPack - html parser to read/write DOM
    CsvHelper - read/write CSV files
*/
namespace cSharp_Scrape
{
    class Program
    {
        // Used for table of content titles 
        public class Row
        {
            public string Title { get; set; }

        }
        static void Main(string[] args)
        {
            // htmlweb is a utility class to get html docs from http
            HtmlWeb web = new HtmlWeb();

            // htmlDocument represents a complete html document
            HtmlDocument doc = web.Load("https://en.wikipedia.org/wiki/Greece");

            // parse and select the nodes containing span.toctext
            var HeaderNames = doc.DocumentNode.SelectNodes("//span[@class='toctext']");        }
    }
}
