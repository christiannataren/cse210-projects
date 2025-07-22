using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;



    public Scripture(Reference reference, String text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] data = text.Split(" ");
        for (int i = 0; i < data.Length; i++)
        {
            _words.Add(new Word(data[i]));
        }

    }



    public bool HideAWord()
    {
        List<Word> noHidden = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                noHidden.Add(w);
            }
        }
        if (noHidden.Count == 0)
        {
            return false;
        }
        int election = new Random().Next(noHidden.Count);
        noHidden[election].Hide();
        return true;
    }
    public Boolean HideRandomWords(int numberToHide)
    {
        bool isThereWords = false;
        for (int i = 0; i < numberToHide; i++)
        {
            if (HideAWord())
            {
                isThereWords = true;
            }
        }


        return isThereWords;
    }
    public String GetDisplayText()
    {
        String text = _reference.GetDisplayText() + " ";

        foreach (Word w in _words)
        {
            text += w.GetDisplayText() + " ";

        }
        return text.Trim();
    }
    public bool IsCompletelyHidden()
    {

        return false;
    }



}