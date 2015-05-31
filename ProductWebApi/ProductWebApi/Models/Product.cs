using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductWebApi.Models
{
    public class Product
    {
        /// <summary>
        /// Product id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents product name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Represents product category
        /// </summary>
        [Required]
        public string Category { get; set; }

        /// <summary>
        /// Represents product price
        /// </summary>
        [Required]
        public int Price { get; set; }

    }
}