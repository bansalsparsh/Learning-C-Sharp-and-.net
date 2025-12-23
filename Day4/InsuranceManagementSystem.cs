using System;

sealed class Authentication
{
    public static void Display(string name, string pass)
    {
        Console.WriteLine("Authentication Confirmed.");
    }
}
abstract class InsurancePolicy
{

    public int PolicyNo{get;init;}

    private double premium;
    public double Premium
    {
        get
        {
            return premium;
        }
        set
        {
            if (value > 0)
            {
                premium=value;
            }
        }
    }
    public string HolderName{get;set;}
    public virtual double PremiumCal()
    {
        return Premium;
    }

    public void PolicyInfo()
    {
        Console.WriteLine($"Policy No: {PolicyNo}");
        Console.WriteLine($"Policy Holder Name: {HolderName}");
        Console.WriteLine($"Premium: {PremiumCal()}");
    }

}


class LifeInsurance : InsurancePolicy
{
    public override double PremiumCal()
    {
        return Premium+500;
    }
    public new void PolicyInfo()
    {
        Console.WriteLine("Life Insurance!!");
        base.PolicyInfo();
    }
}
class HealthInsurance : InsurancePolicy
{
    public sealed override double PremiumCal()
    {
        return Premium+3000;
    }
    public new void PolicyInfo()
    {
        Console.WriteLine("Health Insurance!!");
        base.PolicyInfo();
    }
}


class PolicyStore
{
    private Dictionary<int, string> policy = new Dictionary<int,string>();
    public string this[int idx]
    {
        get{return policy.ContainsKey(idx)?policy[idx]:"Policy not found";}
        set{policy[idx]=value;}
    }
    public string this[string name]
    {
        get{return policy.FirstOrDefault(e=>e.Value==name).Value;}
    }
}