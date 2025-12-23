using System;
class Bank
{
    public int balance;
    public Bank(int balance)
    {
        this.balance = balance;
        Console.WriteLine($"{balance} from Bank class");
    }
    public void BankBal()
    {
        Console.WriteLine(balance);
    }
}
class FD : Bank
{
    public int time;
    public double roi, fdamt;

    static FD()
    {
        Console.WriteLine("You are in static constructor");
    }

    // It is important to call parent class constructor using base if parent class has parameterized constructor
    public FD(int time, double roi, double fdamt):base(40000)
    {
        this.time=time;
        this.roi=roi;
        this.fdamt=fdamt;
    }
    public void FDDetails()
    {
        Console.WriteLine($"Your FD amount is ₹{fdamt} with roi {roi} and time is {time} with current balance {balance}");
    }

}