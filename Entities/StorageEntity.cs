using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime SLastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        public string ProductId { get; set; } //Identificacion del producto

        public ProductEntity Product { get; set; } //Referencia al producto

        public string WarehouseId { get; set; }

        public WarehouseEntity Warehouse { get; set; }

        public ICollection<InOutEntity> InOuts { get; set; }
    }
}
