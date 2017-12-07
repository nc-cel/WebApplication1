using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Account.Models
{
    public class Segment
    {
        [Key, ScaffoldColumn(false)]
        public int SegmentId { get; set; }

        [Required]
        public int? FromId { get; set; }

        [Required]
        public int? ToId { get; set; }

        [Required]
        public float Duration { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public float MaxWeight { get; set; }

        [Required]
        public bool CanBeRecorded { get; set; }

        public int CarrierId { get; set; }


    }
}