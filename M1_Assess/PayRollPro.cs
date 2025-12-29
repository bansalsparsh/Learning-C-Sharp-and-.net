using System;
public abstract class EmployeeRecord
{
   public required string EmployeeName{get;set;}
   public required double[] WeeklyHours{get;set;}
   public abstract double GetMonthlyPay();
  
}
public class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate{get;set;}
    public double MonthlyBonus{get;set;}
    public override double GetMonthlyPay()
    {
        double sum = 0;
        foreach(double x in WeeklyHours)
        {
            sum += x;
        }
        
       return (sum*HourlyRate)+MonthlyBonus;
    }
}
public class ContractEmployee : EmployeeRecord
{
    public double HourlyRate{get;set;}
    public override double GetMonthlyPay()
    {
        double sum = 0;
        foreach(double x in WeeklyHours)
        {
            sum += x;
        }
       return (sum*HourlyRate);
    }
}
class Work
{
    public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();
    public void RegisterEmployee()
    {
        Console.Write("Select Employee Type (1-Full time, 2-Contract): ");
        int type = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Hourly Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        double[] hours = new double[4];
        Console.WriteLine("Enter weekly hours (Week 1 to 4):");
        for (int i = 0; i < 4; i++)
            hours[i] = Convert.ToDouble(Console.ReadLine());

        if (type == 1)
        {
            Console.Write("Enter Monthly Bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            PayrollBoard.Add(new FullTimeEmployee
            {
                EmployeeName = name,
                HourlyRate = rate,
                MonthlyBonus = bonus,
                WeeklyHours = hours
            });
        }
        else
        {
            PayrollBoard.Add(new ContractEmployee
            {
                EmployeeName = name,
                HourlyRate = rate,
                WeeklyHours = hours
            });
        }

        Console.WriteLine("Employee registered successfully!!");
    }

    public Dictionary<string, int> GetOvertimeWeekCounts(double hoursThreshold)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (EmployeeRecord emp in PayrollBoard)
        {
            int count = 0;
            foreach (double h in emp.WeeklyHours)
                if (h >= hoursThreshold) count++;

            if (count > 0)
                dict.Add(emp.EmployeeName, count);
        }

        return dict;
    }

    public double CalculateAverageMonthlyPay()
    {
        if (PayrollBoard.Count == 0) return 0;

        double sum = 0;
        foreach (EmployeeRecord emp in PayrollBoard)
            sum += emp.GetMonthlyPay();

        return sum / PayrollBoard.Count;
    }
}