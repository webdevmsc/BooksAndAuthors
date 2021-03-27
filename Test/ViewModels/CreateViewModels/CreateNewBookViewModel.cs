using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.ViewModels.CreateViewModels
{
    public class CreateNewBookViewModel
    {
        [Required(ErrorMessage = "Не указано название")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Необходимо ввести описание")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Не указан номер выпуска")]
        public string Edition { get; set; }
        public IEnumerable<int> Authors { get; set; }
        public DateTime? PublishedAt { get; set; }
    }
}
