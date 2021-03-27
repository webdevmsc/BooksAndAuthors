using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.ViewModels;
using Test.ViewModels.CreateViewModels;
using Test.ViewModels.EditViewModels;
using Test.ViewModels.UpdatingModels;

namespace Test.Services
{
    public class AuthorService
    {
        private ApplicationDbContext _db;

        public AuthorService(ApplicationDbContext db)
        {
            _db = db;
        }

        //getting all authors
        public IEnumerable<AuthorViewModel> GetAll()
        {
            return _db.Authors.Include(x => x.BooksAuthors)
                .ThenInclude(y => y.Book).ToList()
                .Select(b => new AuthorViewModel(b.Id, b.FullName, b.Dob,
                    b.BooksAuthors.Select(ba => new BookListViewModel(ba.Book.Id, ba.Book.Title))));
        }

        //getting list of authors in partial view
        public IEnumerable<AuthorListViewModel> GetAuthorList()
        {
            return _db.Authors.Select(x => new AuthorListViewModel(x.Id, x.FullName, x.Dob));
        }

        //creating new author
        public async Task<int> Create(CreateNewAuthorViewModel newAuthor)
        {
            if (newAuthor.Books == null)
            {
                _db.Authors.Add(new Author() {FullName = newAuthor.FullName, Dob = newAuthor.Dob});
            }
            else
            {
                var author = new Author()
                {
                    FullName = newAuthor.FullName,
                    Dob = newAuthor.Dob,
                    BooksAuthors = newAuthor.Books.Select(x => new BooksAuthor() { BookId = x }).ToList()
                };
                _db.Authors.Add(author);
            }
            return await _db.SaveChangesAsync();
        }

        //getting author
        public async Task<EditAuthorViewModel> GetAuthor(int id)
        {
            var author = await _db.Authors.Include(y => y.BooksAuthors).ThenInclude(z => z.Book)
                .SingleOrDefaultAsync(x => x.Id == id);
            var editingAuthor = new EditAuthorViewModel()
            {
                Id = author.Id, FullName = author.FullName, Dob = author.Dob, Books = author.BooksAuthors.Select(ba =>
                    new BookListViewModel(ba.Book.Id, ba.Book.Title))
            };
            return editingAuthor;
        }

        //updating author
        public async Task<int> UpdateAuthor(AuthorUpdatingModel updatedAuthor)
        {
            var author = await _db.Authors.Include(x => x.BooksAuthors)
                .SingleOrDefaultAsync(x => x.Id == updatedAuthor.Id);
            author.Dob = updatedAuthor.Dob;
            author.FullName = updatedAuthor.FullName;
            author.BooksAuthors = updatedAuthor.Books?
                .Select(x => new BooksAuthor() {BookId = x, AuthorId = updatedAuthor.Id}).ToList();
            _db.Authors.Update(author);
            return await _db.SaveChangesAsync();
        }

        //deleting author
        public async Task<int> Delete(int? id)
        {
            var author = await _db.Authors.SingleOrDefaultAsync(x => x.Id == id);
            _db.Authors.Remove(author);
            return await _db.SaveChangesAsync();
        }
    }
}