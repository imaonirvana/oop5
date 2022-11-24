namespace Program;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type a key: \n");
        var key = Console.ReadLine();
        var path = @"/home/sawinjer/test.txt";
        
        var documentWorker = new DocumentWorker(path);
        
        switch (key)
        {
            case "pro":
                documentWorker = new ProDocumentWorker(path);
                break;
            case "exp":
                documentWorker = new ExpertDocumentWorker(path);
                break;
        }

        documentWorker.OpenDocument();
        documentWorker.SaveDocument("text");
        documentWorker.EditDocument((oldText) => oldText + "\n new line");
        documentWorker.ChangeExtension("doc");
    }
}