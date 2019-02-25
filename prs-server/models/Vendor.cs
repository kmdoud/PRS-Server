using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace prs.models
{
    public class Vendor
    {
        public int Id { get; set; }
        [Required]
        [StringLength(4)]
        public string Code { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(5)]
        public string Zip { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public bool IsPreferred { get; set; } = false;
        public bool IsActive { get; set; } = true;



        public Vendor()
        {

        }

    }
}
