using System;
using System.Collections.Generic;

public class Scripture
{
    private ScriptureReference _reference;
    private List<WordTracker> _words;

    public Scripture(ScriptureReference reference, string scriptureBlock)
    {
        _reference = reference;
        _words = ListMaker(scriptureBlock);
    }

    private List<WordTracker> ListMaker(string scriptureBlock)
    {
        List<WordTracker> words = new List<WordTracker>();
        string[] wordArray = scriptureBlock.Split(' ');

        foreach (string word in wordArray)
        {
            words.Add(new WordTracker(word));
        }

        return words;
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int numberInListToHide = random.Next(1, _words.Count);

        for (int i = 0; i < numberInListToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string DisplayText()
    {
        string scriptureText = _reference.DisplayText() + " ";

        foreach (WordTracker word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return scriptureText.Trim();
    }

    public bool CheckHiddenAmount()
    {
        foreach (WordTracker word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
