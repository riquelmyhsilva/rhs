using System.Data.Entity;

namespace rhs.Models
{
    public class EmailContext : DbContext
    {
        public DbSet<Email> Email { get; set; }

        public EmailContext() : base("name=ConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>().ToTable("Email");
        }
    }
}