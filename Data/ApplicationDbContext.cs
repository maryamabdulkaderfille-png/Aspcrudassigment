
using Microsoft.EntityFrameworkCore; 
 
public class ApplicationDbContext : DbContext 
{ 
    public ApplicationDbContext(DbContextOptions options) : base(options) 
    { 
        
    } 
   
    public DbSet<Order> Orders {get; set;} 
 
     
    
} 