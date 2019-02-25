using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prs.models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
        [Required]
        public string PartNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        [Required]
        public decimal Price { get; set; } = 0;
        [Required]
        public string Unit { get; set; }
        [StringLength(1000)]
        public string PhotoPath { get; set; }
        public bool IsAcvtive { get; set; } = true;



        public Product()
        {

        }
    }
}
