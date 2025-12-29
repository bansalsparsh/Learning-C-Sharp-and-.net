using System;

namespace StreamBuzz;
class CreatorStats
{
    public string? CreatorName{get;set;}="";
    public double[] WeeklyLikes=new double[4];
}
class Program
{
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("1. Register Creator\n2. Show Top Posts\n3. Calculate Average Likes\n4. Exit\n");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreatorStats creator = new CreatorStats();

                    Console.Write("Enter Creator Name: ");
                    creator.CreatorName=Console.ReadLine();

                    Console.WriteLine("Enter weekly likes (Week 1 to 4):");
                    creator.WeeklyLikes[0]=Convert.ToDouble(Console.ReadLine());
                    creator.WeeklyLikes[1]=Convert.ToDouble(Console.ReadLine());
                    creator.WeeklyLikes[2]=Convert.ToDouble(Console.ReadLine());
                    creator.WeeklyLikes[3]=Convert.ToDouble(Console.ReadLine());
                    RegisterCreator(creator);
                    break;

                case 2:
                    if (EngagementBoard == null)
                    {
                        Console.WriteLine("Create new record first!!");
                    }
                    else{
                        Console.Write("Enter like threshold: ");
                        int thresh=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Dictionary<string, int> dict = GetTopPostCounts(EngagementBoard,thresh);
                        foreach(var x in dict)
                        {
                            Console.WriteLine(x.Key+": "+x.Value);
                        }
                    }
                    break;

                case 3:
                    if (EngagementBoard == null)
                    {
                        Console.WriteLine("Create new record first!!");
                    }
                    else
                    {
                        Console.WriteLine($"Overall average weekly likes: {CalculateAverageLikes()}");
                    }
                    break;

                case 4:
                    Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice!!");
                    break;
            }
            Console.WriteLine("--------------------------------------------------------------");
        }while(choice!=4);
    }

    public static void RegisterCreator(CreatorStats record)
    {
        EngagementBoard.Add(record);
        Console.WriteLine("Creator registered successfully!!");
    }

    public static Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(CreatorStats x in EngagementBoard)
        {
            int count=0;
            foreach(double num in x.WeeklyLikes)
            {
                if (num > likeThreshold) count++;
            }
            dict.Add(x.CreatorName!,count);
        }
        return dict;
    }

    public static double CalculateAverageLikes()
    {
        double avg=0;
        int count=0;
        foreach(CreatorStats x in EngagementBoard)
        {
            foreach(double num in x.WeeklyLikes)
            {
                avg+=num;
                count++;
            }
        }
        return avg/count;
    }
}