namespace DesignPatterns.Behavioral;

abstract class DataParser
{
    public void ProcessData()
    {
        OpenFile();
        ParseFile();
        ProcessRecords();
        CloseFile();
    }

    protected virtual void OpenFile()
    {
        Console.WriteLine("Opening file...");
    }

    protected abstract void ParseFile();

    protected virtual void ProcessRecords()
    {
        Console.WriteLine("Processing data...");
    }

    protected virtual void CloseFile()
    {
        Console.WriteLine("Closing file...");
    }
}

class CsvParser : DataParser
{
    protected override void ParseFile()
    {
        Console.WriteLine("Parsing CSV file...");
    }
}

class JsonParser : DataParser
{
    protected override void ParseFile()
    {
        Console.WriteLine("Parsing JSON file...");
    }
}


