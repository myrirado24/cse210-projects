using System.Text.RegularExpressions;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] rawWords = Regex.Split(text, @"\s+");

        foreach (string rawWord in rawWords)
        {
            if (!string.IsNullOrEmpty(rawWord))
            {
                _words.Add(new Word(rawWord));
            }
        }
    }
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        List<Word> unhiddenWords = _words.Where(word => !word.IsHidden()).ToList();
        int wordsToHide = Math.Min(count, unhiddenWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(0, unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
            unhiddenWords.RemoveAt(randomIndex);
        }
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }
}