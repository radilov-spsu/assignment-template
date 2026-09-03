namespace Hr.Domain;

public sealed class Book
{
    public string Title { get; }
    public bool IsIssued { get; private set; }

    public Book(string title) => Title = title;

    public void Issue()
    {
        if (IsIssued)
            throw new InvalidOperationException("книга уже выдана");
        IsIssued = true;
    }
}
