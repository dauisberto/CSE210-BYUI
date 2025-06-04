public class Scripture
{
    Reference _reference;
    List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] scriptureWords = text.Split(' ');

        foreach (string w in scriptureWords)
        {
            Word word = new Word(w);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)

    {
        List<int> wordsFlag = new List<int>();

        for (int i = 0; i < _words.Count; i += 1)
        {
            if (!_words[i].IsHidden())
            {
                wordsFlag.Add(i);
            }
        }

        if (wordsFlag.Count == 0)
        {
            return;
        }

        Random randy = new Random();
        int counter = 0;

        while (counter < numberToHide && wordsFlag.Count > 0)
        {
            int randomFlag = randy.Next(wordsFlag.Count);
            int helperFlag = wordsFlag[randomFlag];

            _words[helperFlag].Hide();
            wordsFlag.RemoveAt(randomFlag);

            counter += 1;

        }


    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        for (int i = 0; i < _words.Count; i += 1)
        {
            result += _words[i].GetDisplayText() + " ";
        }

        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i += 1)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }

        return true;
    }

}