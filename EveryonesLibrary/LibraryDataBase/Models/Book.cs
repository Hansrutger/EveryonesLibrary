using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Book
    {
        [Key]
        public String ISBN { get; set; }
        public String Title { get; set; }
        public int SignId { get; set; }
        public int PublicationYear { get; set; }
        public String PublicationInfo { get; set; }
        public int Pages { get; set; }

        [ForeignKey("SignId")]
        public Classification Classification { get; set; }
    }
}