namespace DesignPatterns.Creational;

public interface IDocument
{
    void Print();
}

public class WordDocument : IDocument
{
    public void Print()
    {
        Console.WriteLine("Printing Word Document...");
    }
}

public class PdfDocument : IDocument
{
    public void Print()
    {
        Console.WriteLine("Printing Pdf Document...");
    }
}

public abstract class DocumentCreator
{
    public abstract IDocument CreateDocument();

    public void PrintDocument()
    {
        IDocument document = CreateDocument();
        document.Print();
    }
}

public class WordDocumentCreator : DocumentCreator
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

public class PdfDocumentCreator : DocumentCreator
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}