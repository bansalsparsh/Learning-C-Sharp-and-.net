using System;
using System.Linq;

namespace AutonomousRobotAI;

class SensorReading
{
    public int SensorId{get;set;}
    public string Type{get;set;}=null!;
    public double Value{get;set;}
    public DateTime Timestamp{get;set;}
    public double Confidence{get;set;}
}

enum RobotAction
{
    Stop, SlowDown, Reroute, Continue
};

class DecisionEngine
{
    public static List<SensorReading> GetRecentReadings(List<SensorReading> sensorHistory, DateTime fromTime) => sensorHistory.Where(s=>s.Timestamp>=fromTime).ToList();

    public static bool IsBatteryCritical(List<SensorReading> readings) => readings.Any(s=>s.Type.Equals("Battery") && s.Value<20);
    
    public static double GetNearestObstacleDistance(List<SensorReading> readings) => readings.Where(n=>n.Type.Equals("Distance")).ToList().Min(s=>s.Value);

    public static bool IsTemperatureSafe(List<SensorReading> readings) => readings.Where(e=>e.Type.Equals("Temperature")).All(e=>e.Value<90);

    public static double GetAverageVibration(List<SensorReading> readings) => readings.Where(n=>n.Type.Equals("Vibration")).ToList().Average(s=>s.Value);

    public static Dictionary<string,double> CalculateSensorHealth(List<SensorReading> sensorHistory) => sensorHistory.GroupBy(e=>e.Type).ToDictionary(group=>group.Key,group=>group.Average(a=>a.Confidence));

    public static List<string> DetectFaultySensors(List<SensorReading> sensorHistory) => sensorHistory.GroupBy(e=>e.Type).Where(n=>n.Count(e=>e.Confidence<0.4)>2).Select(e=>e.Key).ToList();

    public static bool IsBatteryDrainingFast(List<SensorReading> sensorHistory){
        var r = sensorHistory.Where(e=>e.Type.Equals("Battery")).OrderBy(e=>e.Timestamp).ToList();
        double x=r[0].Value;
        foreach(var i in r)
        {
            if(x >= i.Value) x=i.Value;
            else return false;
        }
        return true;
    }

    public static double GetWeightedDistance(List<SensorReading> readings)
    {
        double weightedSum = readings.Where(n=>n.Type.Equals("Distance")).Sum(e=>e.Value*e.Confidence);
        double totalConf = readings.Where(n=>n.Type.Equals("Distance")).Sum(e=>e.Confidence);
        if (totalConf == 0) return double.MaxValue;
        return totalConf/weightedSum;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        DateTime fromTime=DateTime.Now.AddSeconds(-10);
        List<SensorReading> list = new List<SensorReading>
        {
            new SensorReading{SensorId=1,Type="Distance",Value=0.8,Confidence=0.9,Timestamp=DateTime.Now.AddSeconds(-5)},
            new SensorReading{SensorId=2,Type="Battery",Value=18,Confidence=0.8,Timestamp=DateTime.Now.AddSeconds(-13)},
            new SensorReading{SensorId=3,Type="Temperature",Value=92,Confidence=0.7,Timestamp=DateTime.Now.AddSeconds(-10)},
            new SensorReading{SensorId=4,Type="Vibration",Value=8.2,Confidence=0.3,Timestamp=DateTime.Now.AddSeconds(-3)},
            new SensorReading{SensorId=4,Type="Vibration",Value=8.2,Confidence=0.2,Timestamp=DateTime.Now.AddSeconds(-3)},
            new SensorReading{SensorId=4,Type="Vibration",Value=7.5,Confidence=0.1,Timestamp=DateTime.Now.AddSeconds(-8)},
            new SensorReading{SensorId=5,Type="Battery",Value=75,Confidence=0.5,Timestamp=DateTime.Now.AddSeconds(-7)},
            new SensorReading{SensorId=6,Type="Distance",Value=2.5,Confidence=0.8,Timestamp=DateTime.Now.AddSeconds(-15)},
        };
        foreach(var i in DecisionEngine.GetRecentReadings(list, fromTime))
        {
            Console.WriteLine($"{i.SensorId}, {i.Timestamp}");
        }
        Console.WriteLine("\n"+DecisionEngine.IsBatteryCritical(list));
        Console.WriteLine("\n"+DecisionEngine.GetNearestObstacleDistance(list));
        Console.WriteLine("\n"+DecisionEngine.IsTemperatureSafe(list));
        Console.WriteLine("\n"+DecisionEngine.GetAverageVibration(list)+"\n");
        foreach(var i in DecisionEngine.CalculateSensorHealth(list))
        {
            Console.WriteLine($"{i.Key} -> {i.Value:F2}");
        }
        foreach(var i in DecisionEngine.DetectFaultySensors(list))
        {
            Console.WriteLine($"{i:F2}");
        }
        Console.WriteLine("\n"+DecisionEngine.IsBatteryDrainingFast(list)+"\n");
        Console.WriteLine("\n"+DecisionEngine.GetWeightedDistance(list));
        

    }
}