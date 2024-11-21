using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JShoesApp.Data;
public class JShoesContext : IdentityDbContext<ApplicationUser>
{

    public DbSet<Shoe> Shoes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Address> Address { get; set; }
    
    public JShoesContext(DbContext options)
    {
        
    }

}