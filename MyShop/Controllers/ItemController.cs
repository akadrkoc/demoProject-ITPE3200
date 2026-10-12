using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{

    public class ItemController : Controller
    {
        public IActionResult Table()
        {
            var items = new List<Item>();

            var item1 = new Item
            {
                ItemId = 1,
                Name = "Item 1",
                Price = 10.99m,
                Description = "Description for Item 1",
                ImageUrl = "/images/item1.jpg"
            };

            var item2 = new Item
            {
                ItemId = 2,
                Name = "Item 2",
                Price = 15.99m,
                Description = "Description for Item 2",
                ImageUrl = "/images/item2.jpg"
            };

            items.Add(item1);
            items.Add(item2);

            ViewBag.Items = items;
            return View(items);
        }
    }
}
