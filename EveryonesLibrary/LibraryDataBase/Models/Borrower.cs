using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Borrower
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }//primary Key
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Adress { get; set; }
        public int TelNo { get; set; }
        public Guid accId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("accId")]
        public Account Account { get; set; }
    }
}