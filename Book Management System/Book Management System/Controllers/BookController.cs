using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Book_Management_System.Models;

namespace Book_Management_System.Controllers
{
    public class BookController : Controller
    {
        public static List<Book> books = new List<Book>();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Book book)
        {
            books.Add(book);

            Session["LastBook"] = book.BookName;

            return RedirectToAction("BookList");
        }

        public ActionResult BookList()
        {
            ViewBag.LastBook = Session["LastBook"];

            return View(books);
        }

        public ActionResult Details(int id)
        {
            Book book = books.FirstOrDefault(b => b.BookId == id);

            return View(book);
        }
    }
}