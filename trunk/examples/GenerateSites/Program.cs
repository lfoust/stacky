using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stacky;

namespace GenerateSites
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new StackAuthClient("1.1", new UrlClient(), new JsonProtocol());
            var sites = client.GetSites(pageSize: 100);
            foreach (var site in sites)
            {
                Console.WriteLine(site.MainSite.Name);
            }
            Console.ReadLine();
        }
    }
}