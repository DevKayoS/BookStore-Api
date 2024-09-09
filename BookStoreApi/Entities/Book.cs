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

    public static List<Book> Deletar(int id)
    {
        // encontrando o livro
        var bookToRemove = Books.FirstOrDefault(book => book.Id == id);
        
        Books.Remove(bookToRemove);

        return Books;
    }
    
    public static List<Book> Atualizar(int id, Book bookUpdated)
    {
        // encontrando o livro
        var bookToUpdate = Books.FirstOrDefault(book => book.Id == id);

        if (bookToUpdate != null)
        {
            bookToUpdate.Title = bookUpdated.Title;
            bookToUpdate.Author = bookUpdated.Author;
            bookToUpdate.Genre = bookUpdated.Genre;
            bookToUpdate.Price = bookUpdated.Price;
            bookToUpdate.Qty = bookUpdated.Qty;
        }
        
        return Books;
    }
}