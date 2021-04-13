using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContosoCrafts.Models {
    public class Product {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Maker { get; set; }
        [Required]
        [MaxLength(600)]
        [Column(TypeName="varchar(600)")]
        [JsonPropertyName("img")]
        public string Image { get; set; }
        [Required]
        [MaxLength(600)]
        [Column(TypeName = "varchar(600)")]
        public string Url { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
