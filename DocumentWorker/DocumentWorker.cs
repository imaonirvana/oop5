namespace Program;

public class DocumentWorker
{
    public string Path;
    private string? _text;
    
    public DocumentWorker(string path)
    {
        Path = path;
    }
    
    public string OpenDocument()
    {
        string text = File.ReadAllText(Path);

        _text = text;
        
        return text;
    }

    public virtual void EditDocument(Func<string, string> changeText)
    {
        Console.WriteLine("This function available only in PRO version");
    }
    
    public virtual void SaveDocument(string text)
    {
        Console.WriteLine("This function available only in PRO version");
    }
    public virtual void ChangeExtension(string newExtension)
    {
        Console.WriteLine("This function available only in PRO version");
    }
}