using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Test.Services;
using ClosedXML.Excel;
using Test.ViewModels;


namespace Test.Controllers
{
    public class ExcelController : Controller
    {
        private BookService _bookService;

        public ExcelController(BookService bookService)
        {
            _bookService = bookService;
        }

        //excel home page
        public ActionResult Index()
        {
            return View();
        }
        
        //regular excel-generating algorithm
        public IActionResult GetExcel()
        {
            var booksView = new List<ExcelBookViewModel>();
            _bookService.GetAll().ToList().ForEach(x => x.Authors.ToList().ForEach(u =>
            {
                booksView.Add(new ExcelBookViewModel()
                {
                    AuthorDob = u.DateOfBirth, Description = x.Description, 
                    Edition = x.Edition, Title = x.Title, AuthorName = u.FullName, PublishedAt = x.PublishedAt
                });
            }));

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Books_Authors");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "book_title";
                worksheet.Cell(currentRow, 2).Value = "book_edition";
                worksheet.Cell(currentRow, 3).Value = "book_published_at";
                worksheet.Cell(currentRow, 4).Value = "description";
                worksheet.Cell(currentRow, 5).Value = "author_full_name";
                worksheet.Cell(currentRow, 6).Value = "author_dob";
                foreach (var book in booksView)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = book.Title;
                    worksheet.Cell(currentRow, 2).Value = book.Edition;
                    worksheet.Cell(currentRow, 3).Value = book.PublishedAt;
                    worksheet.Cell(currentRow, 4).Value = book.Description;
                    worksheet.Cell(currentRow, 5).Value = book.AuthorName;
                    worksheet.Cell(currentRow, 6).Value = book.AuthorDob;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        $"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        $"BooksAndAuthors-{DateTime.Now.ToLocalTime()}.xlsx");
                }
            }
        }
    }
}