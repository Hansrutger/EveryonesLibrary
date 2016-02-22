using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Copy
    {
        [Key]
        public int Barcode { get; set; }
        public String Location { get; set; }
        public String StatusId { get; set; }
        public String ISBN { get; set; }
        public String Library { get; set; }

        [ForeignKey("StatusId")]
        public Status Status { get; set; }
    }
}