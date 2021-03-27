using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(int id, string title, string description, string edition, DateTime? publishedAt,
            IEnumerable<AuthorListViewModel> authors)
        {
            Id = id;
            Title = title;
            Description = description;
            Edition = edition;
            PublishedAt = publishedAt;
            Authors = authors;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Edition { get; set; }
        public DateTime? PublishedAt { get; set; }

        public IEnumerable<AuthorListViewModel> Authors { get; set; }
    }
}
