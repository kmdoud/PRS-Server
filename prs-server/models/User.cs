using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prs.models
{
    public class User
{

        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Username { get; set; }
        [StringLength(30)]
        [Required]
        public string Password { get; set; }
        [StringLength(20)]
        public string Firstname { get; set; }
        [StringLength(20)]
        public string Lastname { get; set; }
        [StringLength(100)]
        [Required]
        public string Email { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
        public bool IsReviewer { get; set; } = false;
        public bool IsAdmin { get; set; } = false;
        public bool IsActive { get; set; } = true;

        public User()
        {

        }
}
}
