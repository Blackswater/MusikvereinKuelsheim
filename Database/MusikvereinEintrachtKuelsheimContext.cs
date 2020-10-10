using Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Database
{
    public class MusikvereinEintrachtKuelsheimContext : DbContext
    {
        //public MusikvereinEintrachtKuelsheimContext(DbContextOptions<MusikvereinEintrachtKuelsheimContext> options) : base(options)
        //{
        
        //}
        public MusikvereinEintrachtKuelsheimContext(DbContextOptions<MusikvereinEintrachtKuelsheimContext> options) : base(options) { }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Filename=MusikvereinEintrachtKuelsheim.db", options =>
        //     {
        //         options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
        //     });
        //    base.OnConfiguring(optionsBuilder);
        //}
        //public MusikvereinEintrachtKuelsheimContext() { }

        public DbSet<ContactData> ContactDatas { get; set; }
    }
}
