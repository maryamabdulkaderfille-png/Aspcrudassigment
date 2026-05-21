using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aspcrudassigment4.Pages.Orders;

public class EditModel : PageModel
{
    private readonly ApplicationDbContext _context;
    public EditModel(ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Order order { get; set; } = new();

    public void OnGet(int id)
    {
        order = _context.Orders.Find(id)!;
    }

    public IActionResult OnPost()
    {
        _context.Orders.Update(order);
        _context.SaveChanges();
     
        return RedirectToPage("index");
    }

}