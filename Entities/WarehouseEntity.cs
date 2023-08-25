using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        [Required]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(200)]
        public string WarehouseName { get; set; }

        [StringLength(200)]
        public string WarehouseAdress { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }
    }
}
