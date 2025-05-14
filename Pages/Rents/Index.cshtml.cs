using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Library.Models;
using Microsoft.AspNetCore.Mvc;


public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ILogger<IndexModel> _logger;
    public IList<RentBook> RentBooks { get; set; } = default!;
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }

    [BindProperty(SupportsGet = true)]
    public string SearchString { get; set; } = string.Empty;
    [BindProperty(SupportsGet = true)]
    public string? SortOrder { get; set; }

    public string CurrentSort { get; set; }
    public string BookSort { get; set; }
    public string ResidentSort { get; set; }
    public string DateSort { get; set; }

    public async Task OnGetAsync(int pageNumber = 1)
    {
        CurrentSort = SortOrder ?? "";
        BookSort = String.IsNullOrEmpty(SortOrder) ? "book_desc" : "";
        ResidentSort = SortOrder == "resident" ? "resident_desc" : "resident";
        DateSort = SortOrder == "date" ? "date_desc" : "date";

        int pageSize = 10;
        var query = _context.RentBooks.AsQueryable();

        if (!string.IsNullOrEmpty(SearchString))
        {
            query = query.Where(r => r.Book.BookName.Contains(SearchString) || r.Rent.RenterName.Contains(SearchString));
        }

        switch (SortOrder)
        {
            case "book_desc":
                query = query.OrderByDescending(r => r.Book.BookName);
                break;
            case "renter":
                query = query.OrderBy(r => r.Rent.RenterName);
                break;
            case "renter_desc":
                query = query.OrderByDescending(r => r.Rent.RenterName);
                break;
            case "date":
                query = query.OrderBy(r => r.Rent.RentDate);
                break;
            case "date_desc":
                query = query.OrderByDescending(r => r.Rent.RentDate);
                break;
            default:
                query = query.OrderBy(r => r.Book.BookName);
                break;
        }

        var totalRecords = await query.CountAsync();
        TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
        CurrentPage = pageNumber;

        RentBooks = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Include(rb => rb.Book)
                .ThenInclude(r => r.BookName)
            .Include(rb => rb.Rent)
                .ThenInclude(r => r.RenterName)
            .ToListAsync();
    }

    public IndexModel(AppDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }
}