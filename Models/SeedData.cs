using Microsoft.EntityFrameworkCore;

namespace Library.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Rents.Any())
        {
            return;
        }

        context.Books.AddRange(
            new Book { BookName = "Adventures of Huckleberry Finn", Description = "The Adventures of Huckleberry Finn by Mark Twain, published in 1885, is a quintessential American novel that offers a vivid portrayal of the antebellum South. The story is narrated by Huck Finn, a young boy seeking freedom from his abusive father, who escapes down the Mississippi River with Jim, a runaway slave. The novel explores themes of racism, empathy, and the societal constructs of the time, providing a critical commentary on the institution of slavery and the hypocrisy embedded in the moral values of society."},
            new Book { BookName = "To Kill a Mockingbird", Description = "The story, told by Jean Louise Finch, takes place during three years (1933–35) of the Great Depression in the fictional town of Maycomb, Alabama, the seat of Maycomb County. Nicknamed Scout, the narrator, who is six years old at the beginning of the book, lives with her older brother Jeremy, nicknamed Jem, and their widowed father Atticus, a middle-aged lawyer. They also have a black cook, Calpurnia, who has been with the family for many years and helps Atticus raise the two children."},
            new Book { BookName = "Vinland Saga", Description = "Vinland Saga is initially set mostly in England in 1013 AD, which has been mostly conquered by the Danish King Sweyn Forkbeard. As King Sweyn nears death, his sons, Prince Harald and Prince Canute, argue over his succession. The story draws elements from historical accounts of the period, such as The Flateyjarbók, The Saga of the Greenlanders, and The Saga of Erik the Red."},
            new Book { BookName = "Vagabond", Description = "The story starts in 1600, in the aftermath of the decisive Battle of Sekigahara. Two 17-year-old teenagers who joined the losing side, Takezō Shinmen and Matahachi Hon'iden, lie wounded in the battlefield and pursued by survivor hunters. They manage to escape and swear to become 'Invincible Under The Heavens'."},
            new Book { BookName = "Berserk", Description = "Guts was born from the hanged corpse of his mother and raised as a mercenary by his abusive adoptive father, Gambino, following the death of his adoptive mother, Shisu. After being forced to kill Gambino in self-defense, Guts fled his mercenary group and became a wandering mercenary. His reckless yet powerful fighting style attracts the attention of Griffith, the leader of a mercenary group called the Band of the Hawk, which he makes Guts join after defeating him. The kingdom of Midland hires the Band to aid them in their war against the Chuder Empire, and Guts learns of Griffith's desire to rule his own kingdom and of the pendant he possesses, called the Crimson Behelit."}
        );

        context.SaveChanges();

        List<Rent> rents = new List<Rent>
        {
            new Rent { RenterName = "Hatsumoto Yamano", RentDate = DateTime.Parse("2015-05-13")},
            new Rent { RenterName = "James Stephens", RentDate = DateTime.Parse("2015-11-02")},
            new Rent { RenterName = "Xingqiu Liyuan", RentDate = DateTime.Parse("2016-03-15")},
            new Rent { RenterName = "Marsha Lynch", RentDate = DateTime.Parse("2016-09-02")},
            new Rent { RenterName = "Mavuika Adeptus", RentDate = DateTime.Parse("2016-12-30")},
            new Rent { RenterName = "Xilonen Smith", RentDate = DateTime.Parse("2018-01-12")},
            new Rent { RenterName = "Markus Finch", RentDate = DateTime.Parse("2018-06-04")},
            new Rent { RenterName = "Landon Pinkle", RentDate = DateTime.Parse("2019-02-14")},
            new Rent { RenterName = "Kaitlyn Trouse", RentDate = DateTime.Parse("2020-05-28")},
            new Rent { RenterName = "Marshawn Terry", RentDate = DateTime.Parse("2020-10-02")},
            new Rent { RenterName = "Jaquavius Lefourche", RentDate = DateTime.Parse("2021-01-02")},
            new Rent { RenterName = "Jean Gusteau", RentDate = DateTime.Parse("2022-02-13")},
            new Rent { RenterName = "Dean Martin", RentDate = DateTime.Parse("2022-07-23")},
            new Rent { RenterName = "Bob Ross", RentDate = DateTime.Parse("2023-03-24")},
            new Rent { RenterName = "Steve Potter", RentDate = DateTime.Parse("2024-02-12")},
            new Rent { RenterName = "Monseiur Neuvillette", RentDate = DateTime.Parse("2024-11-27")},
            new Rent { RenterName = "Hiro Sakamoto", RentDate = DateTime.Parse("2025-02-07")}
        };

        context.AddRange(rents);
        context.SaveChanges();

        List<RentBook> rentBooks = new List<RentBook>
        {
            new RentBook { RentID = 1, BookID = 1},
            new RentBook { RentID = 1, BookID = 2},
            new RentBook { RentID = 1, BookID = 3},

            new RentBook { RentID = 2, BookID = 4},

            new RentBook { RentID = 3, BookID = 3},
            new RentBook { RentID = 3, BookID = 2},

            new RentBook { RentID = 4, BookID = 1},
            new RentBook { RentID = 4, BookID = 4},

            new RentBook { RentID = 5, BookID = 1},

            new RentBook { RentID = 6, BookID = 2},
            new RentBook { RentID = 6, BookID = 3},
            new RentBook { RentID = 6, BookID = 4},

            new RentBook { RentID = 7, BookID = 1},
            new RentBook { RentID = 7, BookID = 3},

            new RentBook { RentID = 8, BookID = 1},

            new RentBook { RentID = 9, BookID = 3},

            new RentBook { RentID = 10, BookID = 4},
            new RentBook { RentID = 10, BookID = 2},
            new RentBook { RentID = 10, BookID = 1},

            new RentBook { RentID = 11, BookID = 3},

            new RentBook { RentID = 12, BookID = 2},
            new RentBook { RentID = 12, BookID = 4},

            new RentBook { RentID = 13, BookID = 1},
            new RentBook { RentID = 13, BookID = 2},
            new RentBook { RentID = 13, BookID = 4},

            new RentBook { RentID = 14, BookID = 3},

            new RentBook { RentID = 15, BookID = 1},
            new RentBook { RentID = 15, BookID = 4},

            new RentBook { RentID = 16, BookID = 2},

            new RentBook { RentID = 17, BookID = 1},
            new RentBook { RentID = 17, BookID = 3},
            new RentBook { RentID = 17, BookID = 4},

            new RentBook { RentID = 18, BookID = 1},
            new RentBook { RentID = 18, BookID = 2},
            new RentBook { RentID = 18, BookID = 4},

            new RentBook { RentID = 19, BookID = 3},

            new RentBook { RentID = 20, BookID = 2},
            new RentBook { RentID = 20, BookID = 4},

            new RentBook { RentID = 21, BookID = 1},
            new RentBook { RentID = 21, BookID = 2},

            new RentBook { RentID = 22, BookID = 1},

            new RentBook { RentID = 23, BookID = 4},

            new RentBook { RentID = 24, BookID = 3},
            new RentBook { RentID = 24, BookID = 1},
            new RentBook { RentID = 24, BookID = 4},

            new RentBook { RentID = 25, BookID = 2},

            new RentBook { RentID = 26, BookID = 3},
            new RentBook { RentID = 26, BookID = 1},

            new RentBook { RentID = 27, BookID = 2},
            new RentBook { RentID = 27, BookID = 4},

            new RentBook { RentID = 28, BookID = 1},
            new RentBook { RentID = 28, BookID = 2},
            new RentBook { RentID = 28, BookID = 4},

            new RentBook { RentID = 29, BookID = 2},

            new RentBook { RentID = 30, BookID = 3},
        };

        context.AddRange(rentBooks);
        context.SaveChanges();
    }
}