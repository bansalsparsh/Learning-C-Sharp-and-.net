#pragma warning disable
using System;
class Program
{
    static void Main()
    {

        // // this shows whenever we create a copy of structure the data in the og and copied remains different
        // // but in class if we change copied object data the og data will also be changed
        // StockPrice ogPrice = new StockPrice
        // {
        //     symbol="AAPL",
        //     price=150.50
        // };
        // StockPrice copiedPrice = ogPrice;
        // copiedPrice.price=155.00;
        // Console.WriteLine(ogPrice.price);
        // Console.WriteLine(copiedPrice.price+"\n");


        // Trade ogTrade = new Trade
        // {
        //     tradeId=101,
        //     symbol="AAPL",
        //     quantity=100
        // };
        // Trade copiedTrade = ogTrade;
        // copiedTrade.quantity = 50;

        // Console.WriteLine($"Trade ID is {ogTrade.tradeId} with Symbol {ogTrade.symbol} with quantity {ogTrade.quantity}");
        // Console.WriteLine($"Trade ID is {copiedTrade.tradeId} with Symbol {copiedTrade.symbol} with quantity {copiedTrade.quantity}\n");

        // Trade t = new EquityTrade();
        // Console.WriteLine(t.GetType());








        // Portfolio p1 = new Portfolio{ Name="Growth"};
        // Portfolio p2 = new Portfolio{ Name="Growth123"};
        // Console.WriteLine(p1.Equals(p2)); // checks whether both the strings are equal or not
        // Console.WriteLine(p1.GetHashCode());  // return the hash code for particular string
        // Console.WriteLine(p2.GetHashCode());  






        // Repository<Customer> obj1 = new Repository<Customer>();
        // obj1.Data = new Customer{Name="Rakesh"};
        // Console.WriteLine(obj1.Data.Name);




        // Calculator cal = new Calculator();
        // Console.WriteLine(cal.Calculate(10,20.2));
        // Console.WriteLine(cal.Calculate(20.6,617));


        // NullableClass.NullMethod();






        //Smart Trade
        PriceSnapShot pss = new PriceSnapShot
        {
            StockSymbol="AACP",
            StockPrice=2000
        };
        Console.WriteLine($"Symbol: {pss.StockSymbol}\nPrice: {pss.StockPrice}\n");
        

        TradeRepository<Trade> repo=new TradeRepository<Trade>();


        // Trade 1
        Trade trade1 = new EquityTrade()
        {
            TradeId=1,
            StockSymbol="AAPL",
            Quantity=100,
            MarketPrice=150.50
        };
        Pattern.Check(trade1);
        repo.AddToList(trade1); 
        double amount1=trade1.TradeValue();
        Console.WriteLine($"Trade Value: {amount1}");
        Console.WriteLine($"Brokerage: {amount1.Brokerage()}");
        Console.WriteLine($"Tax(GST): {amount1.Brokerage().GST()}");
        Console.WriteLine(trade1.ToString());

        // Trade 2
        Trade trade2 = new EquityTrade()
        {
            TradeId=2,
            StockSymbol="MSFT",
            Quantity=50,
            MarketPrice=null
        };
        Pattern.Check(trade2);
        repo.AddToList(trade2);
        double amount2=trade2.TradeValue();
        Console.WriteLine($"Trade Value: {amount2}");
        Console.WriteLine($"Brokerage: {amount2.Brokerage()}");
        Console.WriteLine($"Tax(GST): {amount2.GST()}");
        Console.WriteLine(trade2.ToString());

        TradeAnalytics.Display();


        object obj = TradeAnalytics.TotalTrades;
        Console.WriteLine($"Boxed Total Trades: {obj}");
        int Total = (int)obj;
        Console.WriteLine($"Unboxed Total Trades: {Total}");
    }
}