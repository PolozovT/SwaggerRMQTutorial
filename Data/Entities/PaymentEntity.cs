using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("payment", Schema = "public")]
    public class PaymentEntity
    {
        [Key, Column("payment_id")]
        public short PaymentId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("staff_id")]
        public short StaffId { get; set; }

        [Column("rental_id")]
        public short RentalId { get; set; }

        [Column("amount")]
        public double Amount { get; set; }

        [Column("payment_date")]
        public DateTime PaymentDate { get; set; }
    }
}
