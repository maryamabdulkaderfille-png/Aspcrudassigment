using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aspcrudassigment4.Pages.Orders;

public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _context;
    public DeleteModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Order order { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        order = _context.Orders.Find(id)!;
        if (order == null)
        {
            return NotFound();
        }
        return Page();
    }

    public IActionResult OnPost()
    {
        _context.Orders.Remove(order);
        _context.SaveChanges();
    
        return RedirectToPage("Index");
    }

}