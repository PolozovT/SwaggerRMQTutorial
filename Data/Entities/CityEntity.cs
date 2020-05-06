using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("city", Schema = "public")]
    public class CityEntity
    {
        [Key, Column("city_id")]
        public short CityId { get; set; }

        [Column("city")]
        public string City { get; set; }
        
        [Column("country_id")]
        public short CountryId { get; set; }
        
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
