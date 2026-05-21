using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Mvc.RazorPages; 
 
namespace Aspcrudassigment4.Pages.Orders;

public class CreateModel: PageModel 
{ 
 
    private readonly ApplicationDbContext _context; 
    public CreateModel(ApplicationDbContext context) 
    { 
        _context=context; 
    } 
 
    [BindProperty] 
    public string CustomerName { get; set; } = string.Empty; 
    [BindProperty] 
    public string ProductName { get; set; } = string.Empty; 
    [BindProperty] 
    public DateTime OrderDate { get; set; } 
    [BindProperty] 
    public int Quantity { get; set; } 
    [BindProperty] 
    public decimal Price { get; set; } 
  
    public IActionResult OnPost() 
    { 
        var order = new Order
        { 
            CustomerName=CustomerName, 
            ProductName=ProductName, 
            OrderDate=OrderDate, 
            Quantity=Quantity, 
            Price=Price 
        }; 
        _context.Orders.Add(order); 
        _context.SaveChanges(); 
         
      return RedirectToPage(); 
 
    } 
     
 
}