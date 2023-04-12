﻿using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMVCUi.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

        public ShoppingCart ShoppingCart { get; set; }
    }
}
