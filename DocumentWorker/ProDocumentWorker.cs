namespace Program;

public class ProDocumentWorker: DocumentWorker
{
    public ProDocumentWorker(string path): base(path){}

    public override void EditDocument(Func<string, string> changeText)
    {
        var text = OpenDocument();
        var newText = changeText(text);
        SaveDocument(newText);
    }

    public override void SaveDocument(string text)
    {
        File.WriteAllText(Path ,text);
    }
}