using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test.ViewModels.EditViewModels
{
    public class EditBookViewModel
    {
        public int Id { get; set;}
        [Required(ErrorMessage = "Не указано название")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Необходимо ввести описание")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Не указан номер выпуска")]
        public string Edition { get; set; }
        public IEnumerable<AuthorListViewModel> Authors { get; set; }
        public DateTime? PublishedAt { get; set; }
        
    }
}