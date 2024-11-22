public class WordTracker
{
    private string _word;
    private bool _isHidden;

    public WordTracker(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public WordTracker(string word, bool makeHidden)
    {
        _word = word;
        _isHidden = makeHidden;
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
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}
