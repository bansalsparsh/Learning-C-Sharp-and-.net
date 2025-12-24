using System;
using LibrarySystem;
interface IReservable
{
    public void Reserve();
}
interface INotifiable
{
    public void Notify();
}
partial class Book : IReservable, INotifiable
{
    
    void IReservable.Reserve()
    {
        Console.WriteLine("Book reserved successfully.");
    }
    void INotifiable.Notify()
    {
        Console.WriteLine("Notification sent: Your reserved book is ready for pickup.");
    }
}