using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class EmployeeSkill
    {
        [Key]
        public Guid id { get; set; }
        public Guid skill_id { get; set; }
        public Guid employee_id { get; set; }

        [ForeignKey("skill_id")]
        public Skills skills { get; set; }

        [ForeignKey("employee_id")]
        public Employees employee { get; set; }
    }
}
