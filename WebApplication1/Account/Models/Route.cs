using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Account.Models
{
    public class Route
    {
        [ScaffoldColumn(false)]
        public int RouteID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public int? FromId { get; set; }

        [Required]
        public int? ToID { get; set; }

        [Required]
        public double fragttid { get; set; }

    }
}