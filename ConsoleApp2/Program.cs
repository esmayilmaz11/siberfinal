using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmldoc = new XmlDocument();
            string dosya = @"dosya.xml";
            xmldoc.Load(dosya);

            xmldoc.Save(Console.Out);
            Console.ReadLine();
        }
    }
}
