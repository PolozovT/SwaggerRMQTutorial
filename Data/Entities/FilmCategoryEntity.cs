using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("film_category", Schema = "public")]
    public class FilmCategoryEntity
    {
        [Key, Column("film_id")]
        public short FilmId { get; set; }

        [Column("category_id")]
        public short CategoryId { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

    }
}
