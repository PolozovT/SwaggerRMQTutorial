using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("country", Schema = "public")]
    public class CountryEntity
    {
        [Key, Column("country_id")]
        public short CountryId { get; set; }

        [Column("country")]
        public string Country { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
