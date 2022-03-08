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
        
    }
}
