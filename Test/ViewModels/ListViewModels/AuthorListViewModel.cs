using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.ViewModels
{
    public class AuthorListViewModel
    {
        public AuthorListViewModel(int id, string fullName, DateTime? dateOfBirth)
        {
            Id = id;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
