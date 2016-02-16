using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int SignId { get; set; }
        public int PublicationYear { get; set; }
        public string PublicationInfo { get; set; }
        public int Pages { get; set; }
    }
}