using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class EmployeeProject
    {
        [Key]
        public Guid id { get; set; }
        public double utilization { get; set; }
        public Guid employee_id { get; set; }
        public Guid project_id { get; set; }

        [ForeignKey("employee_id")]
        public Employees employee { get; set; }

        [ForeignKey("project_id")]
        public Projects project { get; set; }

    }
}
