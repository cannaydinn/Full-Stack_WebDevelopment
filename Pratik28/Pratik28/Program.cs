

using Pratik28;

// Book sınıfından oluşan liste tanımlaması ve Nesne üretimi
List<Book> books = new List<Book>
{
    new Book(1, "Sefiller", 1),
    new Book(2, "Suç ve Ceza", 2),
    new Book(3, "Anna Karenina", 3),
    new Book(4, "İnsan Ne ile Yaşar", 3),
};

// Author sınıfından oluşan liste tanımlaması ve Nesne üretimi
List<Author> authors = new List<Author>
{
    new Author(1, "Victor Hugo"),
    new Author(2, "Fyodor Dostoevsky"),
    new Author(3, "Lev Tolstoy"),
};

// Kitapları ve yazarları birleştiren "JOIN" LINQ sorgusu
var query = from book in books
             join author in authors
             on book.AuthorID equals author.AuthorID
             select new
             {
                 book.Title,
                 author.Name
             };

// Liste elemanlarını ekrana yazdırma<
foreach (var qy in query)
{
    Console.WriteLine(qy.Title+" -> "+qy.Name);
}