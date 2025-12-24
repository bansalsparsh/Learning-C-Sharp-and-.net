using System;
namespace LibrarySystem;
class Program
{
    static void Main()
    {
        // // imp_exp_interface
        // A a = new X();
        // a.Print();
        // B b = new X();
        // b.Print();





        // // M1 Assessment:

        // // 1.Factory Robot Hazard Analyzer
        // Analyzer obj = new Analyzer();
        // Console.WriteLine(obj.CalculateHazardRisk(1.2,15,"Worn"));

        // // 2.Flip Key Logical Problem Solving
        // Analyzer obj = new Analyzer();
        // Console.WriteLine(obj.CalculateHazardRisk(1.2,15,"Worn"));




        // Task 1
        Book book = new Book{
            Title="C# Fundamentals",
            Author="John Doe",
            ItemId=101
        };
        book.ItemDetails();
        Magazine magazine = new Magazine
        {
            Title="Tech Today",
            Author="Jane Doe",
            ItemId=102
        };
        magazine.ItemDetails();

        // Task 2
        IReservable reserve = book;
        INotifiable notify = book;
        reserve.Reserve();
        notify.Notify();

        // Task 3
        Store st = new Store();
        st.StoreList(book);
        st.StoreList(magazine);
    }
}