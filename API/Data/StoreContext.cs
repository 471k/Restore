using API.Entities;
using API.Entities.OrderAggregate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
    {
        public required DbSet<Product> Products { get; set; }
        public required DbSet<Basket> Baskets { get; set; }
        public required DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
            .HasData(
                new IdentityRole { Id = "bcf665b6-d262-4851-a994-b497e6e258c8", Name = "Member", NormalizedName = "MEMBER" },
                new IdentityRole { Id = "06168779-a6dc-40d9-9eab-7eba2bcb0110", Name = "Admin", NormalizedName = "ADMIN" }
            );
        }

    }
}
