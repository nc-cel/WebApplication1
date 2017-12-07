using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Account.Models
{
    public class Types
    {
        [Key, ScaffoldColumn(false)]
        public int TypeId { get; set; }

        [Required, StringLength(100), Display(Name = "FeeName")]
        public string TypeName { get; set; }

        [Display(Name = "fee_relative")]
        public float? FeeRelativeAmount { get; set; }

        [Display(Name = "fee_absolute")]
        public float? FeeAbsoluteAmount { get; set; }

        [Required]
        public bool Accepting { get; set; }

    }
}