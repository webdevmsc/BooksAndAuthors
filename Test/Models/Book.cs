using System;
using System.Collections.Generic;

#nullable disable

namespace Test
{
    public partial class Book
    {
        public Book()
        {
            BooksAuthors = new HashSet<BooksAuthor>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Edition { get; set; }
        public DateTime? PublishedAt { get; set; }

        public virtual ICollection<BooksAuthor> BooksAuthors { get; set; }
    }
}
