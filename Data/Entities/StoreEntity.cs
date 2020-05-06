using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("store", Schema = "public")]
    public class StoreEntity
    {
        [Key, Column("store_id")]
        public short StoreId { get; set; }

        [Column("manager_stuff_id")]
        public short ManagerStuffId { get; set; }

        [Column("address_id")]
        public short AddressId { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
