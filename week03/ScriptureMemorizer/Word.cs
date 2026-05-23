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
}