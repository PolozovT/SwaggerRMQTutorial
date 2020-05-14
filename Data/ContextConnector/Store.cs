using System;
using System.Collections.Generic;

namespace SwaggerRMQTutorial
{
    public partial class Store
    {
        public short StoreId { get; set; }
        public short ManagerStaffId { get; set; }
        public short AddressId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Staff ManagerStaff { get; set; }
    }
}
