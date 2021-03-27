using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.ViewModels
{
    public class AuthorViewModel
    {
        public AuthorViewModel(int id, string fullName, DateTime? dob, IEnumerable<BookListViewModel> books)
        {
            Id = id;
            FullName = fullName;
            Dob = dob;
            Books = books;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime? Dob { get; set; }
        public IEnumerable<BookListViewModel> Books { get; set; }
    }
}
