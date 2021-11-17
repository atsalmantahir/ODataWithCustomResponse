using System;
using System.ComponentModel.DataAnnotations;

namespace ODataWithCustomResponse.Entities
{
    public class Products
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        [Required]
        [MaxLength(2500)]
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
