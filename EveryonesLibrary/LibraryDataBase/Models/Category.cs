using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Category
    {
        public Borrower CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Period { get; set; }
        public int PenaltyPerDay { get; set; }
    }
}