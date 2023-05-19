using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class UserTypes
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public int access_level { get; set; }
    }
}
