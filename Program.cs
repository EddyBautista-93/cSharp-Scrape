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
            var HeaderNames = doc.DocumentNode.SelectNodes("//span[@class='toctext']");

            // loop through the nodes and add them to the cdv
            var titles = new List<Row>();

            foreach (var item in HeaderNames)
            {
                //Console.WriteLine(item.InnerText);
                titles.Add(new Row { Title = item.InnerText });
            }
            using (var writer = new StreamWriter("Path for csv file")) 
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(titles);
            }
        }
    }
}
