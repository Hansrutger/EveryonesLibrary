using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Book_Author
    {
        [Key]
        [Column(Order=0)]
        public int Aid { get; set; }
        [Key]
        [Column(Order = 1)]
        public String ISBN { get; set; }

        [ForeignKey("Aid")]
        public Author Author { get; set; }
        [ForeignKey("ISBN")]
        public Book Book { get; set; }
    }
}