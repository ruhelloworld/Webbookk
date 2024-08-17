using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreOnline.Models;
namespace BookStoreOnline.Controllers
{
    public class CategoryController : Controller
    {
        BookStoreEntities db = new BookStoreEntities();
        // GET: Category
        public ActionResult Index(int id)
        {
            ViewBag.CategoryName = db.Category.FirstOrDefault(n => n.CategoryID == id).CategoryName;
            return View(db.Products.Where(book => book.CategoryID == id).ToList());
        }
        public ActionResult GetAllBook()
        {
            return View(db.Products.ToList());
        }

        public ActionResult Search(string inputString)
        {
            ViewBag.TextSeatch = inputString;
            var result = db.Products.Where(s => s.ProductName.Contains(inputString) || s.Author.Contains(inputString)).ToList();

            return View(result);
        }
    }
}