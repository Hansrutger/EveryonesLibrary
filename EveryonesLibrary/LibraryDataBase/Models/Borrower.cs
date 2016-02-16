using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Borrower
    {
        public int PersonId { get; set; }//primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int TelNo { get; set; }
        public int CategoryId { get; set; }
    }
}