// two types of interface explicit and implicit (explicit is used for same name conflict handling)

interface A
{
    void Print();
}
interface B
{
    void Print();
}
class X : A, B
{
    void A.Print()
    {
        Console.WriteLine("In A");
    }
    void B.Print()
    {
        Console.WriteLine("In B");
    }
}