using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("language", Schema = "public")]
    public class LanguageEntity
    {
        [Key, Column("language_id")]
        public short LanguageId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
