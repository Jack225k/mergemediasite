using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MergeMediaSite.Models
{
    public class Contact
    {

        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Header { get; set; }
        public string Message { get; set; }


    }
}
