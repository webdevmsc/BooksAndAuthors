using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test.ViewModels.CreateViewModels
{
    //regular view models - I'll not comment other viewmodels cause they're same
    public class CreateNewAuthorViewModel
    {
        [Required(ErrorMessage = "Необходимо указать имя автора")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Необходимо указать дату рождения автора")]
        public DateTime? Dob { get; set; }
        public IEnumerable<int> Books { get; set; }
    }
}
