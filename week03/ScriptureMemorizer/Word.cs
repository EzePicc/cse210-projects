class Word
{
    private bool _isHidden;
    private string _text;

    public void Hide()
    {
        _isHidden = true;
    }
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
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
            return new string('_', _text.Length);
        }
        return _text;
    }

    public string GetText()
    {
        return _text;
    }
}