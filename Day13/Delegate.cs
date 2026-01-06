using System;
// delegate stores reference of the method
delegate void delegatePay(decimal amt);
delegate void delegateNotify(string id);
class Payment
{
    public void PayAmount(decimal amt)
    {
        Console.WriteLine("Payment of "+amt+" is successfull.\n");
    }
    public void SendMail(string id)
    {
        Console.WriteLine("Mail sent on order no. "+id);
    }
    public void SendSMS(string id)
    {
        Console.WriteLine("SMS sent on order no. "+id);
    }
}

//extension class
static class PaymentExtensions
{
    public static bool IsValidPayment(this decimal amount)
    {
        return amount > 0 && amount <= 1_000_000;
    }
}