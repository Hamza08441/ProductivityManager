using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Users
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string remember_token { get; set; }
        public Guid user_type_id { get; set; }

        [ForeignKey("user_type_id")]
        public UserTypes userType { get; set; }

    }
}
