using System;

class ScriptureMemorizer
{
    private Scripture _scripture;
    private List<string> _ListOfScripture;
    private int _totalWordsRemoved = 0;

    public ScriptureMemorizer(Scripture scripture)
    {
        _scripture = scripture;
        _ListOfScripture = new List<string>();
        TextToList();
    }

    private void TextToList()
    {
        _ListOfScripture = _scripture.toString().Split(" ").ToList();
    }

    public void removeWords()
    {
        int numWordsToRemove = 3;
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, _ListOfScripture.Count());
            if (_ListOfScripture[rndIndex].Contains('_') == false)
            {
                _ListOfScripture[rndIndex] = new string('_', _ListOfScripture[rndIndex].Length);
                wordsRemoved++;
                _totalWordsRemoved++;

                if ((_ListOfScripture.Count() - numWordsToRemove) <= _totalWordsRemoved && _totalWordsRemoved < (_ListOfScripture.Count() + 1))
                {
                    wordsRemoved = 3;
                }
            }

        } while (wordsRemoved != numWordsToRemove);
    }

    public string toString()
    {
        return string.Join(" ", _ListOfScripture);
    }

    public bool hasWordsLeft()
    {
        bool retValue = false;

        foreach (string word in _ListOfScripture)
        {
            if (word.Contains("_") == false)
            {
                retValue = true;
                break;
            }
        }

        return retValue;
    }
}