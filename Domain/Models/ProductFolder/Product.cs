using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace Domain.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public string Detail { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public DateTime InsertTime{ get; set; }
        [Required]
        public bool IsProductHaveAttributes { get; set; }

        // NavigationBar       
        public ICollection<CategoryToProduct> Categories { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }
        public ICollection<ProductProperty> Properties { get; set; }
        public ICollection<ProductAttribute> ProductAttributes { get; set; }
        public ICollection<AttributeTemplate> AttributeTemplates { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}