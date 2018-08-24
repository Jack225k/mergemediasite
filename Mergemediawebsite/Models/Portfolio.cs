using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mergemediawebsite.Models
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string SiteHref { get; set; }
        public string ImgHref { get; set; }

    }
}
