using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MergeMediaSite.Models
{
    public class HostingTable
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Plan")]
        public string Instance { get; set; }
        [Display(Name = "Cores")]
        public int Cores { get; set; }
        public double Ram { get; set; }
        public double Storage { get; set; }
        public double Price { get; set; }

    }
}
