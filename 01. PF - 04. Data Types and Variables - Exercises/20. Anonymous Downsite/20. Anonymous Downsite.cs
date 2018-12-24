using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _20.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int affectedWebsitesCount = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal dataLoss = 0;
            decimal totalDataLoss = 0;
            string siteNames = "";
            for (int i = 0; i < affectedWebsitesCount; i++)
            {
                string webSiteData = Console.ReadLine();
                string siteName = webSiteData.Remove(webSiteData.IndexOf(' '));
                string webSiteDataWithoutSiteName = webSiteData.Replace(siteName + ' ', "");
                string siteVisits = webSiteDataWithoutSiteName.Remove(webSiteDataWithoutSiteName.IndexOf(' '));
                string siteCommercialPricePerVisit = webSiteDataWithoutSiteName.Replace(siteVisits + ' ', "");
                dataLoss = long.Parse(siteVisits) * decimal.Parse(siteCommercialPricePerVisit);
                totalDataLoss += dataLoss;
                siteNames += siteName + " ";
            }
            while (siteNames != "")
            {
                string separateSiteName = siteNames.Remove(siteNames.IndexOf(' '));
                Console.WriteLine(separateSiteName);
                siteNames = siteNames.Replace(separateSiteName + ' ', "");
            }
            Console.WriteLine($"Total Loss: {totalDataLoss:f20}");
            BigInteger securityToken = BigInteger.Pow(securityKey, affectedWebsitesCount);
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
