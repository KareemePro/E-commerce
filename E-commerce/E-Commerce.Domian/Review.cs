using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domian
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }
       
        public string Comment { get; set; }

        public int ProudctId { get; set; }
        public Product Product { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
