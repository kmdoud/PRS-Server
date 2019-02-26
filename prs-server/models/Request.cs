using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace prs.models
{
    public class Request
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string Description { get; set; }
        [Required]
        public string Justification { get; set; }
        public string RejectionReason { get; set; }
        public string DeliveryMode { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string Status { get; set; } = "NEW";
        [Column(TypeName = "decimal(12,2)")]
        [Required]
        public decimal Total { get; set; }

        public virtual IList<RequestLine> RequestLines { get; set; }


        public Request()
        {

        }
    }
}
