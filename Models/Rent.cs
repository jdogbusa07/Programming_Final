using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Rent
{

    public int RentID {get; set;}

    [Display(Name = "Renter Name")]
    public string RenterName {get; set;} = string.Empty;

    [Display(Name = "Rent Date")]
    [DataType(DataType.Date)]
    public DateTime RentDate {get; set;}

    [Display(Name = "Books Rented")]
    public List<RentBook>? Products {get; set;} = default!;
}

public class RentBook{
    public int RentID {get; set;}
    public int BookID {get; set;}
    public string? BookName {get; set;}
    public Rent Rent {get; set;} = default!;
    public Book Book {get; set;} = default!;
}