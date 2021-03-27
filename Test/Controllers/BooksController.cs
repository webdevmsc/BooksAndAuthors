using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Test.Services;
using Test.ViewModels.CreateViewModels;
using Test.ViewModels.UpdatingModels;

namespace Test.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;
        private BookService _bookService;

        public BooksController(ILogger<BooksController> logger, BookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        //Get all books
        public IActionResult Index()
        {
            return View(_bookService.GetAll());
        }

        //Create new book
        public IActionResult Create()
        {
            return View();
        }

        //Create new book - post
        [HttpPost]
        public async Task<IActionResult> Create(CreateNewBookViewModel newBook)
        {
            if (ModelState.IsValid)
            {
                var result = await _bookService.Create(newBook);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //Partial view - multiselect with current authors
        public ActionResult GetAuthors()
        {
            return PartialView("_GetAuthors");
        }
        
        //Update book
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _bookService.GetBook(id));
        }
        
        //Update book - post
        [HttpPost]
        public async Task<IActionResult> Edit(BookUpdatingModel updatingBook)
        {
            if (ModelState.IsValid)
            {
                var result = await _bookService.UpdateBook(updatingBook);
                return RedirectToAction("Index");
            }
            else
            {
                return View(await _bookService.GetBook(updatingBook.Id));
            }
        }
        
        //Delete book
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _bookService.Delete(id);
            if (result < 1)
            {
                Console.WriteLine("Mistake!");
            }

            return RedirectToAction("Index");
        }
    }
}
