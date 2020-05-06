using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("rental", Schema = "public")]
    public class RentalEntity
    {
        [Key, Column("rental_id")]
        public int RentalId { get; set; }

        [Column("rental_date")]
        public DateTime RentalDate { get; set; }

        [Column("investory_id")]
        public short InvestoryId { get; set; }

        [Column("customer_id")]
        public short CustomerId { get; set; }

        [Column("return_date")]
        public DateTime ReturnDate { get; set; }

        [Column("staff_id")]
        public int StaffId { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
