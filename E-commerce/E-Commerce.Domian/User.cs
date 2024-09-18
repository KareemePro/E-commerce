using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domian
{
    public class User
    {
        public int Id { get; set; }

        [Required , MaxLength(50)]
        public required string FirstName { get; set; }

        [Required, MaxLength(50)]
        public  string? LastName { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        [Required]
        public string? Password { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public Cart Cart { get; set; }
    }
}
