using System.IO;
using Newtonsoft.Json;
using RecursiveMenuConsoleApp.Services;

namespace RecursiveMenuConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var nav = new PopulateNav();
            var data = new DataService();

            var allMenuItems = data.GetAllMenuItems();
            var navSummary = nav.RecurseThroughMenu(allMenuItems);
            File.WriteAllText(@"C:\Dev\RecursiveMenuConsoleApp\SiteMap\sitemap.json", JsonConvert.SerializeObject(navSummary));
        }
    }
}