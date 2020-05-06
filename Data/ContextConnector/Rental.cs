using System;
using System.Collections.Generic;

namespace SwaggerRMQEx
{
    public partial class Rental
    {
        public Rental()
        {
            Payment = new HashSet<Payment>();
        }

        public short RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public short InventoryId { get; set; }
        public short CustomerId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public short StaffId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
