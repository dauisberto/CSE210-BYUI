public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentQty()
    {
        int commentQuantity;
        commentQuantity = 0;

        commentQuantity = _comments.Count;
        return commentQuantity;
    }

    public void GetDisplayText()
    {
        Console.WriteLine("");
        Console.WriteLine($"Video: {_title}, Author: {_author}, Length (seconds): {_length}");
        Console.WriteLine("");
        Console.WriteLine($"Number of comments: {GetCommentQty()}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetText()}");
        }
    }
}