using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JShoesApp.Data;
public class JShoesAppContext : IdentityDbContext<ApplicationUser>
{

    public DbSet<Shoe> Shoes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Address> Address { get; set; }
    
    public JShoesAppContext(DbContextOptions options): base(options){ }

}