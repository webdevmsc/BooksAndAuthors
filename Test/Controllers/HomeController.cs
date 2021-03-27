using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using Test.Models;
using Test.Services;
using Test.ViewModels;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BookService _bookService;
        private AuthorService _authorService;

        public HomeController(ILogger<HomeController> logger, BookService bookService, AuthorService authorService)
        {
            _logger = logger;
            _bookService = bookService;
            _authorService = authorService;
        }

        //home page
        public IActionResult Index()
        {
            return View(new InfoViewModel() { TotalAuthors = _authorService.GetAll().Count(), TotalBooks = _bookService.GetAll().Count() });
        }

        //default privacy
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
