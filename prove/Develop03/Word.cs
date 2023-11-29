using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        this._text = text;
        _isHidden = false;
    }

    public string GetText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}

public class Reference
{
    private string reference;

    public Reference(string reference)
    {
        this.reference = reference;
    }

    public string GetReference()
    {
        return reference;
    }
}