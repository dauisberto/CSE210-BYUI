using System.IO;
using System.Runtime.Serialization;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public Journal()
    {

    }

    public void AddNewEntry(Entry entry)
    {

        _entries.Add(entry);
    }

    public void DeleteEntry(int _deletenumber)
    {
        //This is my creativity plus, a delete entry functionality :)
        // I got help from: https://www.designgurus.io/answers/detail/how-to-remove-elements-from-a-list-in-c
        _entries.RemoveAt(_deletenumber);
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))

        foreach (Entry ent in _entries)
        {
            outputFile.WriteLine($"{ent._changeDate}, {ent._promptText}, {ent._entryText}");
        }
    }

    public List<Entry> LoadFromFile(string file)
    {
        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry();
            entry._changeDate = parts[0];
            entry._promptText=parts[1];
            entry._entryText=parts[2];
            entries.Add(entry);


            
        }
        return entries;

    }

}