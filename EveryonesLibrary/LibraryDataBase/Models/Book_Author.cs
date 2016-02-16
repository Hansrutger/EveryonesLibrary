using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Book_Author
    {
        public Author Aid { get; set; }
        public Book ISBN { get; set; }
    }
}