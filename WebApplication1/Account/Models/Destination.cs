﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Account.Models
{
    public class Destination
    {
        [Key, ScaffoldColumn(false)]
        public int DestinationId { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string DestinationName { get; set; }

        public virtual ICollection<Destination> Destinations { get; set; }

    }
}