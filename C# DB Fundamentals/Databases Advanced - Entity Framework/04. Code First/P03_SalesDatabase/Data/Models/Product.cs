﻿namespace P03_SalesDatabase.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
