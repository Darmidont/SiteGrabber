using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySiteGrabber
{
    class Program
    {
        static void Main(string[] args)
        {

            string _url = "http://www.rambler.ru";
            var siteGrabber = new SiteGrabber(_url);
            siteGrabber.GetSiteContent();
            Console.WriteLine("end a program");
            Console.ReadLine();
        }
    }
}
