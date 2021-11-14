using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace pizza.Models
{
    public class NewPizza
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MaxLength(3)]
        public string ShortName { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EPizzaStockStatusModel StockStatus { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Ingredients { get; set; }

        [Required]
        [Range(0, 1000)]
        public double Price { get; set; }
    }
}