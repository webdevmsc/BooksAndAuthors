using System;
using System.Collections.Generic;

#nullable disable

namespace Test
{
    //many-to-many relationship
    public class BooksAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
