// two types of interface explicit and implicit (explicit is used for same name conflict handling)

interface IPrintable
{
    void Print();
    const int a=0;
    static int b=0;
    // int x=0; //not allowed
}

class Report : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing report");
    }
}

