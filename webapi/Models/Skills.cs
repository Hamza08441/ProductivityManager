using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Skills
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
    }
}
