using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Test.ViewModels;
using Test.ViewModels.CreateViewModels;
using Test.ViewModels.EditViewModels;
using Test.ViewModels.UpdatingModels;

namespace Test.Services
{
    public class BookService
    {
        private ApplicationDbContext _db;

        public BookService(ApplicationDbContext db)
        {
            _db = db;
        }

        //getting all books
        public IEnumerable<BookViewModel> GetAll()
        {
            return _db.Books.Include(x => x.BooksAuthors).ThenInclude(y => y.Author).ToList()
                .Select(b => new BookViewModel(b.Id, b.Title, b.Description, b.Edition, b.PublishedAt,
                    b.BooksAuthors.Select(ba => new AuthorListViewModel(ba.Author.Id, ba.Author.FullName, ba.Author.Dob))));
        }

        //creating new book
        public async Task<int> Create(CreateNewBookViewModel newBook)
        {
            if (newBook.Authors == null)
            {
                _db.Books.Add(new Book() {Title = newBook.Title, PublishedAt = newBook.PublishedAt, Description = newBook.Description, Edition = newBook.Edition});
            }
            else
            {
                var book = new Book()
                {
                    Description = newBook.Description, Title = newBook.Title, Edition = newBook.Edition,
                    PublishedAt = newBook.PublishedAt,
                    BooksAuthors = newBook.Authors.Select(x => new BooksAuthor() {AuthorId = x}).ToList()
                };
                _db.Books.Add(book);
            }
            return await _db.SaveChangesAsync();
        }

        //getting book by id
        public async Task<EditBookViewModel> GetBook(int id)
        {
            var book = await _db.Books.Include(y => y.BooksAuthors).ThenInclude(z => z.Author)
                .SingleOrDefaultAsync(x => x.Id == id);
            var editingAuthor = new EditBookViewModel()
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                Edition = book.Edition,
                PublishedAt = book.PublishedAt,
                Authors = book.BooksAuthors.Select(ba => new AuthorListViewModel(ba.Author.Id, ba.Author.FullName, ba.Author.Dob))
            };
            return editingAuthor;
        }

        //updating book
        public async Task<int> UpdateBook(BookUpdatingModel updatedModel)
        {
            var book = await _db.Books.Include(x => x.BooksAuthors)
                .SingleOrDefaultAsync(u => u.Id == updatedModel.Id);
            book.Description = updatedModel.Description;
            book.Title = updatedModel.Title;
            book.Edition = updatedModel.Edition;
            book.PublishedAt = updatedModel.PublishedAt;
            book.BooksAuthors =
                updatedModel.Authors?.Select(x => new BooksAuthor() {AuthorId = x, BookId = updatedModel.Id}).ToList();
            _db.Books.Update(book);
            return await _db.SaveChangesAsync();
        }
        
        //deleting book
        public async Task<int> Delete(int? id)
        {
            var book = await _db.Books.SingleOrDefaultAsync(x => x.Id == id);
            _db.Books.Remove(book);
            return await _db.SaveChangesAsync();
        }
        
    }
}
