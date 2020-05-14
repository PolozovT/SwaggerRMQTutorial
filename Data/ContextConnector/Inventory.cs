using System;
using System.Collections.Generic;

namespace SwaggerRMQTutorial
{
    public partial class Inventory
    {
        public Inventory()
        {
            Rental = new HashSet<Rental>();
        }

        public short InventoryId { get; set; }
        public short FilmId { get; set; }
        public short StoreId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Film Film { get; set; }
        public virtual ICollection<Rental> Rental { get; set; }
    }
}
