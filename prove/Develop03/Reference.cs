public class ScriptureReference
{
    public string Reference { get; set; }

    public ScriptureReference(string reference)
    {
        Reference = reference;
    }

    public override string ToString()
    {
        return Reference;
    }
}
