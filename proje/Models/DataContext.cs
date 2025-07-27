using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Yorum> Yorumlar => Set<Yorum>();
        public DbSet<Sikayet> Sikayetler => Set<Sikayet>();
        public DbSet<SacModeli> sacModelleri => Set<SacModeli>();


    }
}
