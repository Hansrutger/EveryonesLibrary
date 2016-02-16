using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Copy
    {
        public int Barcode { get; set; }
        public String Location { get; set; }
        public String StatusId { get; set; }
        public String ISBN { get; set; }
        public String Library { get; set; }
    }
}