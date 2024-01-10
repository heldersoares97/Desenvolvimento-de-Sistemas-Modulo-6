using Apicompassdois.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Apicompassdois.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Compass>? Compasses { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        //public object Compass { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Compass>().HasData(
                new Compass { Id = 1, Name = "Helder", Compass_URL = "https://www.segueviagem.com.br/wp-content/uploads/2020/09/shutterstock_505603756-scaled.jpg", Destiny = "Minas Gerais", Price = 200.00m },
                new Compass { Id = 2, Name = "Paulo", Compass_URL = "https://www.segueviagem.com.br/wp-content/uploads/2020/06/shutterstock_1032911857-1200x675.jpg", Destiny = "Rio de Janeiro", Price = 700.00m },
                new Compass { Id = 3, Name = "Samuel", Compass_URL = "https://blog.4bus.com.br/wp-content/uploads/2021/06/10-cidades-para-visitar-no-rio-grande-do-sul-10-cidades-para-visitar-no-rio-grande-do-sul-4.jpg", Destiny = "Rio Grande do Sul", Price = 900.00m }
            );
        }
    }
}
