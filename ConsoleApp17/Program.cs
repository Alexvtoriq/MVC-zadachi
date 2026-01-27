using System;
using System.Linq;

class StartUp
{
    static void Main()
    {
        using (var db = new BookstoreContext())
        {
            db.Database.EnsureCreated();

            if (!db.Authors.Any())
            {
                var author1 = new Author
                {
                    Name = "George Orwell",
                    BirthYear = 1903
                };

                var author2 = new Author
                {
                    Name = "J. K. Rowling",
                    BirthYear = 1965
                };

                db.Authors.AddRange(author1, author2);

                db.Books.AddRange(
                    new Book
                    {
                        Title = "1984",
                        Genre = "Dystopian",
                        PublishedYear = 1949,
                        Author = author1
                    },
                    new Book
                    {
                        Title = "Animal Farm",
                        Genre = "Political Satire",
                        PublishedYear = 1945,
                        Author = author1
                    },
                    new Book
                    {
                        Title = "Harry Potter and the Philosopher's Stone",
                        Genre = "Fantasy",
                        PublishedYear = 1997,
                        Author = author2
                    }
                );

                db.SaveChanges();
            }

           
            foreach (var author in db.Authors)
            {
                Console.WriteLine($"{author.Name} ({author.BirthYear})");

                foreach (var book in db.Books.Where(b => b.AuthorId == author.Id))
                {
                    Console.WriteLine(
                        $"  - {book.Title} | {book.Genre} | {book.PublishedYear}"
                    );
                }
            }
        }
    }
}
