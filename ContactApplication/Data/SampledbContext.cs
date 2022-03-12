using ContactApplication.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactApplication.Data
{
    public class SampledbContext : DbContext
    {
        public SampledbContext(DbContextOptions<SampledbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
