using System;
using System.Collections.Generic;
using System.Linq;
using RecursiveMenuConsoleApp.DAO;
using RecursiveMenuConsoleApp.Models;

namespace RecursiveMenuConsoleApp.Services
{
    public interface IPopulateNavService
    {
        List<NavItemSummary> RecurseThroughMenu(List<MenuItem> menuItems, int? parentId = null);
    }

    public class PopulateNav : IPopulateNavService
    {
        public List<NavItemSummary> RecurseThroughMenu(List<MenuItem> menuItems, int? parentId = null)
        {
            var menu = new List<NavItemSummary>();

            var thisLevel = menuItems.Where(m => m.ParentId == parentId);

            foreach (var menuItem in thisLevel)
            {
                var children=RecurseThroughMenu(menuItems,menuItem.Id);
                var navItem=new NavItemSummary { Id=menuItem.Id,Link = menuItem.Link,Title = menuItem.Title ,Children = children};
                menu.Add(navItem);
            }
            return menu;
        }
    }
}
