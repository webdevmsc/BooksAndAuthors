using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.ViewModels
{
    public class BookListViewModel
    {
        public BookListViewModel(int id, string title)
        {
            Id = id;
            Title = title;
        }
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
