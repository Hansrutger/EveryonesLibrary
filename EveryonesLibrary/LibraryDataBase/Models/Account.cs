using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid accId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PersonId { get; set; }

        //[ForeignKey("PersonId")]
        //public Borrower Borrower { get; set; }
    }
}