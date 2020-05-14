using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQTutorial.Data
{
    [Table("customer", Schema = "public")]
    public class CustomerEntity
    {
        [Key, Column("customer_id")]
        public short CustomerId { get; set; }

        [Column("store_id")]
        public short StoreId { get; set; }

        [Column("first_name")]
        public string firstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("address_id")]
        public short AddressId { get; set; }

        [Column("activebool")]
        public bool Activebool { get; set; }

        [Column("create_date")]
        public DateTime CreateDate { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [Column("active")]
        public short Active { get; set; }
    }
}
