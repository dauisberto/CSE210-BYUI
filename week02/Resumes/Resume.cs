public class Resume
{
    public string _username="";
    public List<Job> _works=new List<Job>();

    public Resume()
    {

    }

    public void DisplayResumeInfo()
    {
        Console.WriteLine($"{_username}");
        Console.WriteLine("Jobs: ");

        foreach (Job item in _works)
        {
            item.DisplayJobInfo();
        }
    }

}