namespace lb53;

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
        Console.WriteLine("Правка документа доступна у версії Про");
    }

    public virtual void SaveDocument(string text)
    {
        Console.WriteLine("Збереження документа доступне у версії Про");
    }
    public virtual void ChangeExtension(string newExtension)
    {
        Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
    }
}