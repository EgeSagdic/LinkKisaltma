using Microsoft.EntityFrameworkCore;

namespace LinkKisaltma.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<TBLLink> TBLLink { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=5.2.84.31;Database=gulerar1_linkkisaltma;User Id=guler_link;Password=V^03lba82;encrypt=false");

            optionsBuilder.UseSqlServer(@"Server=LAPTOP-FEBL0K35\SQLEXPRESS;Database=LinkKisaltma;Trusted_Connection=true;encrypt=false");
        }
    }
}
