using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Author
    {
        [Key]
        public int Aid { get; set; }  // tror att vi sätter 
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int BirthYear { get; set; }
    }
}