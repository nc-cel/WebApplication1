using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Account.Models
{
    public class Fee
    {
        [ScaffoldColumn(false)]
        public int FeeID { get; set; }

        [Required, StringLength(100), Display(Name = "FeeName")]
        public string FeeName { get; set; }

        [Display(Name = "Price")]
        public double? FeeRelativeAmount { get; set; }

    }
}