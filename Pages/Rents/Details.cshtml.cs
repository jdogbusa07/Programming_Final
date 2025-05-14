using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library.Models;

public class DetailsModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ILogger<DetailsModel> _logger;

    public DetailsModel(AppDbContext context, ILogger<DetailsModel> logger)
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
