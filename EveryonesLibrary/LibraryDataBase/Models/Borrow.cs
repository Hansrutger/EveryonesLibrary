using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Borrow
    {
        public Borrower PersonId { get; set; }// forien key
        public Copy Barcode { get; set; }   // forien key
        public int BorrowDate { get; set; } //primary key
        public int ToBeReturnedDate { get; set; }
        public int ReturnedDate { get; set; }
    }
}