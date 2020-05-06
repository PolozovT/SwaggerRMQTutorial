using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwaggerRMQEx.Data
{
    [Table("staff", Schema = "public")]
    public class StaffEntity
    {
        [Key, Column("staff_id")]
        public short StaffId { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("second_name")]
        public string SecondName { get; set; }

        [Column("address_id")]
        public short AddressId { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("store_id")]
        public short StoreId { get; set; }

        [Column("active")]
        public bool Active { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [Column("picture")]
        public string Picture { get; set; } // type ?
    }
}
