using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Account.Models
{
    public class Destination
    {
        [ScaffoldColumn(false)]
        public int DestinationID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string DestinationName { get; set; }

    }
}