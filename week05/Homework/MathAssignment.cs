public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string booksection, string problems) : base(name, topic)
    {
        _textbookSection = booksection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string homeworklist;
        homeworklist = ($"Section: {_textbookSection} Problems {_problems}");
        return homeworklist;

    }
}