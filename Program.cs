using System;
using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
namespace cSharp_Scrape
{
    class Program
    {
        public class Row
        {
            public string Title { get; set; }

        }
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();

            HtmlDocument doc = web.Load("https://en.wikipedia.org/wiki/Greece");
        }
    }
}
