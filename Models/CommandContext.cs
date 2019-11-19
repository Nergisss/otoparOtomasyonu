using Microsoft.EntityFrameworkCore;

namespace otopark.Models
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options):base(options)
        {
        
        }
        public DbSet<imagePath> CommandItems{get;set;}

    }

}