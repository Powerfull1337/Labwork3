using Labwork3.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Labwork3.Data
{
    public class CRUDContext:DbContext
    {
        public CRUDContext(DbContextOptions options) :base(options) 
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
 