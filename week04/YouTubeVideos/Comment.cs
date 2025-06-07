public class Comment
{
    public string _commentUser;
    public string _text;

    public Comment(string user, string text)
    {
        _commentUser = user;
        _text = text;

    }

    public string GetText()
    {
        string getText = "";
        getText = ($"{_commentUser} said: {_text}");
        return getText;
    }
}