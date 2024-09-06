namespace BookStoreApi.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public Genre Genre {get; set;}
    public double Price { get; set; }
    public int Qty { get; set; }

    public static List<Book> Books = new List<Book>();

    public static void Adicionar(Book book)
    {
        Books.Add(book);
    }

    public static List<Book> Listar()
    {
        return Books;
    }
}