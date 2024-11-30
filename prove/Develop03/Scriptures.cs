class Scripture
{
    private Reference Reference { get; set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = Math.Min(3, Words.Count(w => !w.IsHidden)); // Hide up to 3 words per iteration

        List<Word> visibleWords = Words.Where(w => !w.IsHidden).ToList();

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }

    public string GetRenderedText()
    {
        string text = string.Join(" ", Words);
        return $"{Reference}\n{text}";
    }
}