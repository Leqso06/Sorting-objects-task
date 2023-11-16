namespace Sorting_Objects;
public class Book
{
    public Book(string title, double price)
    {
        Title = title;
        Price = price;
        CompareTo compareTo = new(CompareTo);
    }

    public string Title { get; }
    public double Price { get; }

    public override string ToString()
    {
        return $"{Title} - {Price:0.00}";
    }

    public bool CompareTo(object? obj)
    {
        Book other = obj as Book;

        return this.Price > other.Price;
    }
}