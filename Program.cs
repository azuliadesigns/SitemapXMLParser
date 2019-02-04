using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SitemapXMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument urldoc = new XmlDocument();
            urldoc.Load("Sitemap.xml");

            XmlNodeList xnList = urldoc.GetElementsByTagName("url");

            foreach (XmlNode node in xnList)
            {
                Console.WriteLine("url " + node["loc"].InnerText);
                Console.WriteLine("priority " + node["priority"].InnerText);
                Console.WriteLine("last modified " + node["lastmod"].InnerText);
                Console.WriteLine("change frequency " + node["changefreq"].InnerText);
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}