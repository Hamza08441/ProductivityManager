using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using webapi.Models;

namespace webapi.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }
        public DbSet<EmployeeProject> employeeProject { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<EmployeeSkill> employeeSkill { get; set; }
        public DbSet<Projects> projects { get; set; }
        public DbSet<Skills> skills { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<UserTypes> userTypes { get; set; }
    }
}
