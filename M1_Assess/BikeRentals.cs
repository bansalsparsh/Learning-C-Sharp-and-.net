using System;
using System.Collections.Generic;
public class Bike
{
    public string Model{get;set;}
    public int PricePerDay{get;set;}
    public string Brand{get;set;}
}
class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count+1;
        Program.bikeDetails.Add(key,new Bike
        {
            Model = model,
            PricePerDay = pricePerDay,
            Brand = brand
        });
    }
    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> grouped = new SortedDictionary<string, List<Bike>>();

        foreach (var item in Program.bikeDetails)
        {
            Bike bike = item.Value;

            if (!grouped.ContainsKey(bike.Brand))
                grouped.Add(bike.Brand, new List<Bike>());

            grouped[bike.Brand].Add(bike);
        }

        return grouped;
    }
}
public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int,Bike>();
    public static void Main(string[] args)
    {
        int choice=0;
        BikeUtility utility = new BikeUtility();
        while(choice!=3)
        {
            Console.WriteLine("\n1. Add Bike Details\n2. Group Bikes By Brand\n3. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter the brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter the price per day: ");
                    int price = int.Parse(Console.ReadLine());

                    utility.AddBikeDetails(model, brand, price);

                    Console.WriteLine("Bike details added successfully");
                    break;
                case 2:
                    SortedDictionary<string, List<Bike>> result = utility.GroupBikesByBrand();

                    foreach (var item in result)
                    {
                        foreach (Bike bike in item.Value)
                        {
                            Console.WriteLine(item.Key + " " + bike.Model);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Thank you!!\nApplication Terminated!!");
                    break;
                default:
                    Console.WriteLine("Invalid Input!!");
                    break;
            }
        }
    }
}
