  using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
                
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objlist = _db.Item;
            return View(objlist);
        }
        // GET-Create
        public IActionResult Create()
        {
            return View();
        }
        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]   
        public IActionResult Create(Item obj)
        {
            _db.Item.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            /*return View();*/
        }

    }
}
