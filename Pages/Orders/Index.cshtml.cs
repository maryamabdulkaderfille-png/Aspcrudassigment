
using Microsoft.AspNetCore.Mvc.RazorPages; 
 
namespace Aspcrudassigment4.Pages.Orders;

public class IndexModel : PageModel 
{ 
    // Connect to Database  
    private readonly ApplicationDbContext _context; 
    public IndexModel(ApplicationDbContext context) 
    { 
        _context=context; 
    } 
 
    public List<Order> orders {get; set;} = new(); 
 
    public void OnGet() 
    { 
            orders=_context.Orders.ToList(); 
    } 
} 