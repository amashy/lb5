using System.Text;

namespace lb53;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть ключ: ");
        var key = Console.ReadLine();
        var path = @"d:\word.doc";

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
        documentWorker.SaveDocument("Максим Бакуменко, ФІТ 2-3");
        documentWorker.EditDocument((oldText) => oldText + "\nДТЕУ");
        documentWorker.ChangeExtension("docx");
    }
}