using AsyncTaskApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AsyncTaskApp.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        // Синхронный метод
        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books.ToList();
            ViewBag.Books = books;
            return View();
        }

        // Синхронный метод
        public async Task<ActionResult> BookList()
        {
            IEnumerable<Book> books = await db.Books.ToListAsync();
            ViewBag.Books = books;
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}