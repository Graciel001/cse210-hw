public class ScriptureReference
{
    private string Reference { get; set;}

    public ScriptureReference(string reference)
    {
        Reference = reference;
    }

    public override string ToString()
    {
        return Reference;
    }
}