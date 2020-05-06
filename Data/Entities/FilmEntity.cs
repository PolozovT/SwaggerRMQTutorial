using NpgsqlTypes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("film", Schema = "public")]
    public class FilmEntity
    {
        [Key, Column("film_id")]
        public short FilmId { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("release_year")]
        public int ReleaseYear { get; set; }

        [Column("language_id")]
        public short LanguageId { get; set; }

        [Column("rental_duration")]
        public int RentalDuration { get; set; }

        [Column("rental_rate")]
        public double RentalRate { get; set; }

        [Column("length")]
        public int Length { get; set; }

        [Column("replacement_cost")]
        public double ReplacementCost { get; set; }
      
        [Column("rating")]
        public MpaaRating Rating { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [Column("special_features")]
        public string[] SpecialFeatures { get; set; }

        [Column("fulltext")]
        public NpgsqlTsVector Fulltext { get; set; }
    }
}
