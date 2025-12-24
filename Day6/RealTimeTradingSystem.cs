#pragma warning disable
using System;
struct PriceSnapShot
{
    public PriceSnapShot(){}
    public required string StockSymbol;
    public int StockPrice;

}
abstract class Trade
{
    public int TradeId;
    public required string StockSymbol;
    public int Quantity;
    public abstract double TradeValue();
    public override string ToString()
    {
        return $"Trade Id:{TradeId}, Symbol: {StockSymbol}, Quantity: {Quantity}\n";
    }
}
class EquityTrade : Trade
{
    public double? MarketPrice;
    public override double TradeValue()
    {
        double price=MarketPrice??0.0;
        return price*Quantity;
    }
}
public class TradeRepository<T> where T : class
{
    public int count=0;
    List<T> list = new List<T>();
    public void AddToList(T a)
    {
        list.Add(a);
        count++;
        TradeAnalytics.TotalTrades++;
        Console.WriteLine("Trade added successfully!!");
    }
}
static class TradeAnalytics
{
    public static int TotalTrades;
    public static void Display()
    {

        Console.WriteLine($"Total trades executed: {TotalTrades}\n");
    }
}
static class Calculation
{
    public static double Brokerage(this double amount)
    {
        return amount/1000;
    }
    public static double GST(this double amount)
    {
        return amount*0.18;
    }
}
class Pattern
{
    public static void Check(Trade trade)
    {
        if(trade is EquityTrade et)
        {
            Console.WriteLine("Processing Equity Trade.");
        }
    }
}