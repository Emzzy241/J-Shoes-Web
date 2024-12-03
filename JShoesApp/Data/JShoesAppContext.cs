using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using JShoesApp.Models;

namespace JShoesApp.Data;
public class JShoesAppContext : IdentityDbContext<ApplicationUser>
{

    public DbSet<Shoe> Shoes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Address> Addresses { get; set; }
    
    public JShoesAppContext(DbContextOptions options): base(options){ }

}