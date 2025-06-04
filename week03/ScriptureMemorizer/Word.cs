public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;

    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;

    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            int quantity = _text.Length;
            string new_text = new string('_', quantity);
            return new_text;
        }
        else
        {
            return _text;
        }
    }
}