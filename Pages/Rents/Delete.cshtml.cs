using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library.Models;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ILogger<DeleteModel> _logger;

    public DeleteModel(AppDbContext context, ILogger<DeleteModel> logger)
    {
        _context = context;
        _logger = logger;
    }


    [BindProperty]
    public Rent Rent { get; set; } = default!;

 public void OnGet() 
    {

    }

    public async Task<IActionResult> OnPostAsync()
    {
        var rent = await _context.Rents.FindAsync(Rent.RentID);
        if (rent == null) return NotFound();

        _context.Rents.Remove(rent);
        await _context.SaveChangesAsync();
        return RedirectToPage("Index");
    }
}
