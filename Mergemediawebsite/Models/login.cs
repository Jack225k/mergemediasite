using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mergemediawebsite.Models
{
    public class login
    {
        [Key]
        public int id { get; set; }
        public string userName { get; set; }
        [DisplayName("Password")]
        [PasswordPropertyText]
        public string password { get; set; }
        public string confrimPassword { get; set; }
    }


}
