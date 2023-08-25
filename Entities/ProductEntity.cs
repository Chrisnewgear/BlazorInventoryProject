using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        [Required]
        public int TotalQuantity { get; set; }

        public string CategoryId { get; set; } //# Identificacion de la categoria

        public CategoryEntity Category { get; set; } // Referencia a la categoria

        public ICollection<StorageEntity> Storages { get; set; } // Lista de storages
    }
}
