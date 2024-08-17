using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreOnline.Models;

namespace BookStoreOnline.Controllers
{
    public class ProductDetailController : Controller
    {
        BookStoreEntities db = new BookStoreEntities();
        // GET: ProductDetail
        public ActionResult Index(int id)
        {
            ViewBag.Book = db.Products.FirstOrDefault(book => book.ProductID == id);
            ViewBag.MoreBook = db.Products.ToList().Take(4);
            return View();
        }
    }
}