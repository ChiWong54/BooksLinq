using BooksLinq;

// Main Program
Console.WriteLine("Book List LINQ\n");

var books = new List<Book>
{
    new Book(1, "The Catcher in the Rye", "J.D. Salinger", 277,
        "Little, Brown and Company", 1951, "Fiction", true),
    new Book(2, "War and Peace", "Leo Tolstoy", 1225, 
        "The Russian Messenger (serial)", 1869, "Historical Fiction", true),
    new Book(3, "1984", "George Orwell", 328, 
        "Seeker & Warburg", 1949, "Dystopian", true)
};

// DisplayBookList(books);

books.AddRange(new List<Book>
  {
    new Book(4, "The Hobbit", "J.R.R. Tolkien", 310,
         "George Allen & Unwin", 1937, "Fantasy", true),
    new Book(5, "Tender Is the Night", "F. Scott Fitzgerald", 317,
         "Charles Scribner", 1934, "Fiction", true),
    new Book(6, "The Great Gatsby", "F. Scott Fitzgerald", 180,
         "Charles Scribner", 1925, "Fiction", true),
    new Book(7, "To Kill a Mockingbird", "Harper Lee", 336,
         "J.B. Lippincott & Co.", 1960, "Fiction", true),
    new Book(8, "The Alchemist", "Paulo Coelho", 208,
         "HarperTorch", 1988, "Adventure", true),
    new Book(9, "Brave New World", "Aldous Huxley", 268,
         "Chatto & Windus", 1932, "Dystopian", true),
    new Book(10, "Moby-Dick", "Herman Melville", 635,
         "Harper & Brothers", 1851, "Adventure", true),
    new Book(11, "Pride and Prejudice", "Jane Austen", 279,
         "T. Egerton, Whitehall", 1813, "Romance", true),
    new Book(12, "The Lord of the Rings", "J.R.R. Tolkien", 1178,
         "George Allen & Unwin", 1954, "Fantasy", true),
    new Book(13, "Becoming", "Michelle Obama", 448,
         "Crown", 2018, "Autobiography", false),
    new Book(14, "Sapiens: A Brief History of Humankind", "Yuval Harari", 443,
         "Harper", 2011, "Non-Fiction", false),
    new Book(15, "Educated", "Tara Westover", 334,
         "Random House", 2018, "Autobiography", false),
    new Book(17, "Thinking, Fast and Slow", "Daniel Kahneman", 499,
         "Farrar, Straus and Giroux", 2011, "Non-Fiction", false),
    new Book(18, "The Body Keeps the Score", "Bessel van der Kolk", 464,
         "Viking", 2014, "Non-Fiction", false)
  }
);

// DisplayBookList(books);

// Demos

// Demo 1 - Display a list of books by the author J.R.R. Tolkien
/*
Console.WriteLine("\nTolkien Books");
var tolkienBooks = books
    .Where(b => b.Author == "J.R.R. Tolkien")
    .ToList();

DisplayBookList(tolkienBooks);
*/

// Demo 2 - Display a list of books by the author J.R.R. Tolkien or Coelho
/*
Console.WriteLine("\nTolkien Or Coelho Books");
var tolkienOrCoelhoBooks = books
    .Where(b => b.Author == "J.R.R. Tolkien" || b.Author == "Paulo Coelho")
    .ToList();

DisplayBookList(tolkienOrCoelhoBooks);
*/

// Demo 3 - Display Books with the text "is" in the title
/*
Console.WriteLine("\nBooks with IS in the title");
var isBooks = books
    .Where(b => b.Title.Contains("is", StringComparison.CurrentCultureIgnoreCase))
    .ToList();

DisplayBookList(isBooks);
*/

// Demo 4 - Display Books with a page count between 450 and 1000(inclusive)
/*
Console.WriteLine("\nBooks with a page count between 450 and 1000 (inclusive)");
var mediumSizeBooks = books
    .Where(b => b.PageCount >= 450 && b.PageCount <= 1000)
    .ToList();

DisplayBookList(mediumSizeBooks);
*/

// Demo 5 - Display Books in the Autobiography and Romance Genre
/*
Console.WriteLine("\nBooks in the Autobiography and Romance Genre");
var genrefilterList = new List<string> { "Autobiography", "Romance"};
var GenreFilteredBooks = books
    .Where(b => genrefilterList.Contains(b.Genre))
    .ToList();

DisplayBookList(GenreFilteredBooks);
*/

// Demo 6 - Display a list of books sorted by Genre
/*
Console.WriteLine("\nBooks sorted by Genre");
var booksSortedByGenre = books
    .OrderBy(b => b.Genre)
    .ToList();

DisplayBookList(booksSortedByGenre);
*/

// Demo 7 - Display a list of books sorted by Genre and Title
/*
Console.WriteLine("\nBooks sorted by Genre and Title");
var booksSortedByGenreAndTitle = books
    .OrderBy(b => b.Genre)
    .ThenBy(b => b.Title)
    .ToList();

DisplayBookList(booksSortedByGenreAndTitle);
*/

// Demo 8 - Display a list of books sorted by Year Published(latest first) and Title
/*
Console.WriteLine("\nBooks sorted by Year Published (latest first) and Title");
var booksSortedByPublishedYearAndTitle = books
    .OrderByDescending(b => b.PublishedYear)
    .ThenBy(b => b.Title)
    .ToList();

DisplayBookList(booksSortedByPublishedYearAndTitle);
*/

// Demo 9 - Display oldest and newest book - Year Published
/*
Console.WriteLine("\nOldest and newest book - Year Published");
var oldestBookYear = books
    .Select(b => b.PublishedYear)
    .Min();

Console.WriteLine($"Oldest Year Published: {oldestBookYear}");

var newestBookYear = books
    .Max(b => b.PublishedYear);

Console.WriteLine($"Most Recent Year Published: {newestBookYear}");
*/

// Demo 10 - Display J.R.R. Tolkien first book
/*
Console.WriteLine("\nJ.R.R. Tolkien first book");
var tolkienFirstBook = books
    .Where(b => b.Author == "J.R.R. Tolkien")
    .OrderBy(b => b.PublishedYear)
    .FirstOrDefault();

Console.WriteLine(tolkienFirstBook);
*/

// Demo 11 - Count the number of books in each genre
/*
Console.WriteLine("\nBook Count for each Genre");
var genreCounts = books
    .GroupBy(b => b.Genre)
    .OrderBy(g => g.Key)
    .Select(g => new {
        Genre = g.Key,
        Count = g.Count()
       }
    )
    .ToList();

foreach (var gc in genreCounts)
{
    Console.WriteLine($"{gc.Genre}: {gc.Count}");
}
*/

// Further Queries

// List all books that are classics and have more than 300 pages
/*
Console.WriteLine("\nBooks that are classics and have more than 300 pages");
var z = books
    .Where(b => b.IsClassic == true && b.PageCount >= 300)
    .ToList();

DisplayBookList(z);
*/

// List all books that are not classics and were published after 1950
/*
Console.WriteLine("\nBooks that are not classics and were published after 1950");
var y = books
    .Where(b => b.IsClassic == false && b.PublishedYear >= 1950)
    .ToList();

DisplayBookList(y);
*/

// List books by a specific publisher (George Allen & Unwin) and order them by page count
/*
Console.WriteLine("\nBooks published by George Allen & Unwin and ordered by page count");
var x = books
    .Where(b => b.Publisher == "George Allen & Unwin")
    .OrderByDescending(b => b.PageCount)
    .ToList();

DisplayBookList(x);
*/

// List books that are either classics or have more than 500 pages
/*
Console.WriteLine("\nBooks that are either classics or have more than 500 pages");
var w = books
    .Where(b => b.IsClassic == true || b.PageCount >= 500)
    .ToList();

DisplayBookList(w);
*/

// Advanced Query
// Find the average page count of books in each genre
/*
Console.WriteLine("\nAverage page count of books in each genre");

var genreCounts = books
    .GroupBy(b => b.Genre)
    .OrderBy(g => g.Key)
    .Select(g => new {
        Genre = g.Key,
        Count = g.Count(),
        PageCount = g.Sum(b => b.PageCount)
    }
    )
    .ToList();

foreach (var gc in genreCounts)
{
    Console.WriteLine($"{gc.Genre}: number of books: {gc.Count}" +
        $", number of pages: {gc.PageCount}, average page count: {gc.PageCount/gc.Count}");
}
*/

// Display the longest book in each genre
Console.WriteLine("\nLongest Book in each Genre");

var genreCounts = books
    .OrderByDescending(b => b.PageCount)
    .GroupBy(b => b.Genre)
    .OrderBy(g => g.Key)
    .Select(g => new {
        Genre = g.Key,
        longestBook = g.First()
    }
    )
    .ToList();

foreach (var gc in genreCounts)
{
    Console.WriteLine($"{gc.Genre}: {gc.longestBook}");
}

// Tutorial: Students List

// Methods
static void DisplayBookList(List<Book> bookList) 
{
    foreach (var book in bookList) 
    {
        Console.WriteLine(book);
    }
}


