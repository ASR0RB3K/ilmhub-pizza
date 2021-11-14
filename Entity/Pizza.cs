using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace pizza.Entity
{
    public class Pizza
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(3)]
        public string ShortName { get; set; }

        public EPizzaStockStatus? StockStatus { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Ingredients { get; set; }

        [Required]
        [Range(0, 1000)]
        public double Price { get; set; }
        
        public Pizza(Guid id, string title, string shortName, string ingredients, double price)
        {
            Id = Guid.NewGuid();
            Title = title;
            ShortName = shortName;
            Ingredients = ingredients;
            Price = price;
        }
    }
}