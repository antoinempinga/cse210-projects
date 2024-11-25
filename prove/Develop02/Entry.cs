public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
    }
}
