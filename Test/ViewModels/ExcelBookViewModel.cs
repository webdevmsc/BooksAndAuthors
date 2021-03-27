using System;

namespace Test.ViewModels
{
    public class ExcelBookViewModel
    {
        public string Title { get; set; }
        public string Edition { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public DateTime? AuthorDob { get; set; }
    }
}