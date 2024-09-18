﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domian
{
    public class Category
    {
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public required string Name { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
