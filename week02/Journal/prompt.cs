class PromptGenerator
{
    public List<string> _promptList = new List<string>()
        {
            "Why this day is wonderfull? ",
            "Who was the most important person for you this day? ",
            "How you can make better this day? ",
            "What was your favorite activity of today? ",
            "You feel like someone around you need help with something? ",
            "Tell me, how many people you helped today? ",
            "What is something that make you want to wake up tomorrow? ",
            "What you want to eat tomorrow? "
        };
    public List<string> _usedList = new List<string>();
    public System.Random random = new Random();
    public string GeneratePrompt()
    {
        if (_usedList.Count >= _promptList.Count())
        {
            _usedList.Clear();
        }
        var r = random.Next(_promptList.Count);
        var randomEntry = _promptList[r];

        while (_usedList.Contains(r.ToString()))
        {
            r = random.Next(_promptList.Count);
            randomEntry = _promptList[r];
        }
        string prompt = randomEntry;

        _usedList.Add(r.ToString());
        return randomEntry;
    }
}