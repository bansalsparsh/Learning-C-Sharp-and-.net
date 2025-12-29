using System;
namespace LibrarySystem;
class Program
{
    static void Main()
    {
        // // 1.Factory Robot Hazard Analyzer
        // Analyzer obj = new Analyzer();
        // Console.WriteLine(obj.CalculateHazardRisk(0.5,10,"Critical"));
        // Console.WriteLine(obj.CalculateHazardRisk(1.3,4,"Worn"));
        // Console.WriteLine(obj.CalculateHazardRisk(0.7,26,"Critical"));
        // Console.WriteLine(obj.CalculateHazardRisk(0.3,14,"Optimal"));



        // // 2.Flip Key Logical Problem Solving
        // FlipLogic flip = new FlipLogic();
        // Console.WriteLine(flip.CleanseAndInvert("Aeroplane"));
        // Console.WriteLine(flip.CleanseAndInvert("Cowages"));
        // Console.WriteLine(flip.CleanseAndInvert("Magic"));
        // Console.WriteLine(flip.CleanseAndInvert("Kinder World"));
        // Console.WriteLine(flip.CleanseAndInvert("B@rbie"));



        // 3.PayRollPro
        Work obj = new Work();
        int choice;
        do
        {
            Console.WriteLine("1. Register Employee\n2. Show Overtime Summary\n3. Calculate Average Monthly Pay\n4. Exit");
            
            Console.WriteLine("Enter Your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    obj.RegisterEmployee();
                    break;

                case 2:
                    Console.Write("Enter hours threshold: ");
                    double threshold = Convert.ToDouble(Console.ReadLine());
                    var result = obj.GetOvertimeWeekCounts(threshold);

                    if (result.Count == 0)
                        Console.WriteLine("No overtime recorded this month");
                    else
                        foreach (var item in result)
                            Console.WriteLine(item.Key + " - " + item.Value);
                    break;

                case 3:
                    Console.WriteLine("Overall average monthly pay: " +
                        obj.CalculateAverageMonthlyPay());
                    break;

                case 4:
                    Console.WriteLine("Logging off — Payroll processed successfully!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            
        } while (choice != 4);
    }   
}