using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Book_Author
    {
        public int Aid { get; set; }
        public Book ISBN { get; set; }

        [ForeignKey("Aid")]
        public Author Author { get; set; }
        [ForeignKey("ISBN")]
        public Book Book { get; set; }
    }
}