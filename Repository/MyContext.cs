using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("MyContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Comments)
                .WithRequired(pc => pc.Product)
                .HasForeignKey(pc => pc.ProductId);

            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Product> Products { get; set; }

        public System.Data.Entity.DbSet<Repository.Models.ProductComment> ProductComments { get; set; }
    }
}
