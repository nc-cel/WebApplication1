using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Account.Models
{
    public class Carrier
    {
        [Key, ScaffoldColumn(false)]
        public int CarrierId { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CarrierName { get; set; }

    }
}