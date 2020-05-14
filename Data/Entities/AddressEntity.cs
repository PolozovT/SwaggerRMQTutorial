using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQTutorial.Data
{
    [Table("address", Schema = "public")]
    public class AddressEntity
    {
        [Key, Column("address_id")]
        public short AddressId { get; set; }
        
        [Column("address")]
        public string Address { get; set; }

        [Column("address_2")]
        public string Address2 { get; set; }

        [Column("distinct")]
        public string Distinct { get; set; }

        [Column("city_id")]
        public short CityId { get; set; }

        [Column("postal_code")]
        public int PostalCode { get; set; }

        [Column("phone")]
        public long Phone { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
