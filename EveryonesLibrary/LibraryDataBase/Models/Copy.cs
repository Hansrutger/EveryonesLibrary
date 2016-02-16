using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Copy
    {
        public int Barcode { get; set; }
        public string Location { get; set; }
        public string StatusId { get; set; }
        public string ISBN { get; set; }
        public string Library { get; set; }
    }
}