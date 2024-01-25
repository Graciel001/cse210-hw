using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptureText
{
    private List<Word> Words {get; set;}

    public ScriptureText(string text)
    {
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, Words.Count / 2);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(Words.Count);
            Words[index].Hide();
        }
    }
    public override string ToString()
    {
        return string.Join(" ", Words.Select(word => word.ToString()));
    }
}