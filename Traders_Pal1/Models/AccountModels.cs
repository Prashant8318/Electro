using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traders_Pal1.Models
{
    public class AccountModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public bool Result { get; set; }
        public string TransDate { get; set; }
       // public List<AccountModels> objlst { get; set; }
    }
}