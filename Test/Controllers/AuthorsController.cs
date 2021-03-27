using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Test.Services;
using Test.ViewModels.CreateViewModels;
using Test.ViewModels.UpdatingModels;

namespace Test.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly ILogger<BooksController> _logger;
        private AuthorService _authorService;

        public AuthorsController(ILogger<BooksController> logger, AuthorService authorService)
        {
            _logger = logger;
            _authorService = authorService;
        }

        //getting all books
        public IActionResult Index()
        {
            return View(_authorService.GetAll());
        }
        
        //Create
        public IActionResult Create()
        {
            return View();
        }
        //Create - post
        [HttpPost]
        public async Task<IActionResult> Create(CreateNewAuthorViewModel newAuthor)
        {
            
            //Validation
            if (ModelState.IsValid)
            {
                var result = await _authorService.Create(newAuthor);
                if (result > 0)
                {
                    Console.WriteLine("Mistake!");
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //Update author
        public async Task<IActionResult> Edit(int Id)
        {
            return View(await _authorService.GetAuthor(Id));
        }
        
        //Partial view - getting current booklist
        public ActionResult GetBooks()
        {
            return PartialView("_GetBooks");
        }
        
        //Update author - post
        [HttpPost]
        public async Task<IActionResult> Edit(AuthorUpdatingModel editingAuthor)
        {
            //Validation
            if (ModelState.IsValid)
            {
                var result = await _authorService.UpdateAuthor(editingAuthor);
                if (result < 0)
                {
                    Console.WriteLine("Mistake!");
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(await _authorService.GetAuthor(editingAuthor.Id));
            }
        }

        //Deleting author
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _authorService.Delete(id);
            if (result < 0)
            {
                Console.WriteLine("Mistake!");
            }

            return RedirectToAction("Index");
        }
    }
}
