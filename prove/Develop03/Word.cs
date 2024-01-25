public class Word
{
    private string Text {get; set;}
    private bool IsHidden {get; set;}

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? "- - -" : Text;
    }
}