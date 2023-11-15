namespace Sorting_Objects;
public class Book : IComparable
{
    public Book(string title, double price)
    {
        Title = title;
        Price = price;
    }

    public string Title { get; }
    public double Price { get; }

    public override string ToString()
    {
        return $"{Title} - {Price:0.00}";
    }

    public int CompareTo(object? obj)
    {
        Book other = obj as Book;

        if (this.Price > other.Price)
        {
            return 1;
        }
        return -1;
    }
}