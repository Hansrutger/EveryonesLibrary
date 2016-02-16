using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        [ForeignKey("StatusId")]
        public Copy Copy { get; set; }
    }
}