using System.Collections.Generic;

namespace RecursiveMenuConsoleApp.Models
{
    public class NavItemSummary
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public List<NavItemSummary> Children { get; set; }
    }
}
