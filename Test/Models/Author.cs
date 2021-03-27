using System;
using System.Collections.Generic;

#nullable disable

namespace Test
{
    public class Author
    {
        public Author()
        {
            BooksAuthors = new HashSet<BooksAuthor>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime? Dob { get; set; }

        public virtual ICollection<BooksAuthor> BooksAuthors { get; set; }
    }
}
