using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Book
{
    public int BookID {get; set;}
    public string BookName {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
}