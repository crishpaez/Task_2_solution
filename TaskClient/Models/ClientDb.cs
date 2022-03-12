using Microsoft.EntityFrameworkCore;

namespace TaskClient.Models
{
    public class ClientDb : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public ClientDb()
        {

        }
        public ClientDb(DbContextOptions<ClientDb> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Client>().HasIndex(x => x.Name);
        //    modelBuilder.Entity<Client>().Property(x => x.Id).ValueGeneratedNever();
        //}
    }
}
