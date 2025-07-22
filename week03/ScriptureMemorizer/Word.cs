class Word
{
    private String _text;
    private bool _isHidden;

    public Word(String text)
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
    public String GetDisplayText()
    {
        String text = _text;
        if (_isHidden)
        {
            text = "";
            for (int i = 0; i < _text.Length; i++)
            {
                text += "-";
            }
        }
        return text;
    }
}