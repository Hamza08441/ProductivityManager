using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Projects
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string region { get; set; }
        public Guid leader_id { get; set; }

        [ForeignKey("leader_id")]
        public Users user { get; set; }

    }
}
