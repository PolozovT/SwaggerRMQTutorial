﻿using System;
using System.Collections.Generic;

namespace SwaggerRMQTutorial
{
    public partial class Customer
    {
        public Customer()
        {
            Payment = new HashSet<Payment>();
            Rental = new HashSet<Rental>();
        }

        public short CustomerId { get; set; }
        public short StoreId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public short AddressId { get; set; }
        public bool? Activebool { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? Active { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Rental> Rental { get; set; }
    }
}
