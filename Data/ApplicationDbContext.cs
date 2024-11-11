using CRUD_Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Assignment.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public virtual DbSet<Drink> dbAkijFood { get; set; }
    }
}
