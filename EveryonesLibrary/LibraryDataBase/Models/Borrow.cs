using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryDataBase.Models
{
    public class Borrow
    {
        public int PersonId { get; set; }// forien key
        public int Barcode { get; set; }   // forien key
        [Key]
        public int BorrowDate { get; set; } //primary key
        public int ToBeReturnedDate { get; set; }
        public int ReturnedDate { get; set; }

        [ForeignKey("Barcode")]
        public Copy Copy { get; set; }

        [ForeignKey("PersonID")]
        public Borrower Borrower { get; set; }
    }
}