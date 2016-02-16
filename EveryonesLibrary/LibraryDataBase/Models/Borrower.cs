using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryDataBase.Models
{
    public class Borrower
    {
        public int PersonId { get; set; }//primary Key
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Adress { get; set; }
        public int TelNo { get; set; }
        public int CategoryId { get; set; }
    }
}