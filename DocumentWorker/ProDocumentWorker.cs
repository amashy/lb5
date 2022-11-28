namespace lb53;

public class ProDocumentWorker : DocumentWorker
{
    public ProDocumentWorker(string path) : base(path) { }

    public override void EditDocument(Func<string, string> changeText)
    {
        var text = OpenDocument();
        var newText = changeText(text);
        SaveDocument(newText);
        Console.WriteLine("Документ відредаговано");
    }

    public override void SaveDocument(string text)
    {
        File.WriteAllText(Path, text);
    }

    public override void ChangeExtension(string newExtension)
    {
        Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
    }
}
