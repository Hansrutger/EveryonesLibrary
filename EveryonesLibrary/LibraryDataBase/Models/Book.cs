using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Book
    {
        public String ISBN { get; set; }
        public String Title { get; set; }
        public int SignId { get; set; }
        public int PublicationYear { get; set; }
        public String PublicationInfo { get; set; }
        public int Pages { get; set; }
    }
}