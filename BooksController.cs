
using Microsoft.AspNetCore.Mvc;

namespace LibraryappLr4
{
    public class BooksController : Controller
    {
        public ActionResult Index()
        {
            // Код для отримання списку книг, наприклад з файлу конфігурації
            // і передачі його в представлення

            return View();
        }
    }
}
