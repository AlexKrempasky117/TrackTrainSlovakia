using Microsoft.EntityFrameworkCore;
using IdemeVlakomZas.Models;

namespace IdemeVlakomZas.Data
{
    public class ApplicationDbContent : DbContext

    {
        public ApplicationDbContent(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Trains> VlakySVK { get; set; }
    }
}
