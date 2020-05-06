using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("investory", Schema = "public")]
    public class InvestoryEntity
    {
        [Key, Column("investory_id")]
        public short InvestoryId { get; set; }

        [Column("film_id")]
        public short FilmId { get; set; }

        [Column("store_id")]
        public short StoreId { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
